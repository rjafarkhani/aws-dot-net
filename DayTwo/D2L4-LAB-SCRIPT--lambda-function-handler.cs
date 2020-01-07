        // Copyright <YEAR> Amazon.com, Inc. or its affiliates. All Rights Reserved.
        // SPDX-License-Identifier: MIT-0
        // Copyright <YEAR> Amazon.com, Inc. or its affiliates. All Rights Reserved.
        // SPDX-License-Identifier: MIT-0

        public async Task<string> FunctionHandler(S3Event evnt, ILambdaContext context)
        {
            string[] fileExtentions = new string[] { ".jpg", ".jpeg" };
            var s3Event = evnt.Records?[0].S3;
            if (s3Event == null)
            {
                return null;
            }
            try
            {
                foreach (var record in evnt.Records)
                {
                    LambdaLogger.Log("----> File: " + record.S3.Object.Key);
                    if (!fileExtentions.Contains(Path.GetExtension(record.S3.Object.Key).ToLower()))
                    {
                        LambdaLogger.Log("File Extention is not supported - " + s3Event.Object.Key);
                        continue;
                    }
                    string suffix = Path.GetExtension(record.S3.Object.Key).ToLower();
                    Stream imageStream = new MemoryStream();
                    using (var objectResponse = await S3Client.GetObjectAsync(record.S3.Bucket.Name, record.S3.Object.Key))
                    using (Stream responseStream = objectResponse.ResponseStream)
                    {
                        using (Image<Rgba32> image = Image.Load<Rgba32>(responseStream))
                        {
                            image.Mutate(ctx => ctx.Resize(image.Width / 4, image.Height / 4));
                            image.Save(imageStream, new JpegEncoder());
                            imageStream.Seek(0, SeekOrigin.Begin);
                        }
                    }

                    // Creating a new S3 ObjectKey for the resized objects

                    string resizedObjectKey = null;

                    int endSlash = record.S3.Object.Key.ToLower().LastIndexOf("/");

                    if (endSlash > 0)

                    {
                        string S3ObjectName = record.S3.Object.Key.ToLower().Substring(endSlash + 1);
                        int beginSlash = 0;
                        if (endSlash > 0)
                        {
                            beginSlash = record.S3.Object.Key.ToLower().Substring(0, endSlash - 1).LastIndexOf("/");
                            if (beginSlash > 0)
                            {
                                resizedObjectKey = record.S3.Object.Key.ToLower().Substring(0, beginSlash) + "resized-images/" + S3ObjectName;
                            }
                            else
                            {
                                resizedObjectKey = "resized-images/" + S3ObjectName;
                            }
                        }
                    }
                    else
                    {
                        resizedObjectKey = "resized-images/" + record.S3.Object.Key.ToLower();
                    }

                    LambdaLogger.Log("----> Resized filed Key: " + resizedObjectKey);

                    await S3Client.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = record.S3.Bucket.Name,
                        Key = resizedObjectKey,
                        InputStream = imageStream
                    });
                }

                LambdaLogger.Log("Processed " + evnt.Records.Count.ToString());
                return null;
            }
            catch (Exception e)
            {
                context.Logger.LogLine($"Error getting object {s3Event.Object.Key} from bucket {s3Event.Bucket.Name}. Make sure they exist and your bucket is in the same region as this function.");
                context.Logger.LogLine(e.Message);
                context.Logger.LogLine(e.StackTrace);
                throw;
            }

        }