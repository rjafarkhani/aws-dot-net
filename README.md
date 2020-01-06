# AWS/Slalom .NET Immersion Days

## PREREQUISITES
1.	Day 1 & 2 Pre-requisites:
    - Please ensure you have access to an AWS account from your organization (ISD, DPSS etc.). If you do not have access to an AWS account from your organization, please create an account by following the steps at the link https://aws.amazon.com/premiumsupport/knowledge-center/create-and-activate-aws-account/.
        - NOTE: we will only be creating resources in the free tier and removing the resources at the end of the class so you will not incur any charges if you create your personal AWS account

2.	Day 2 (.NET on AWS) Pre-requisites
    - Please install Visual Studio 2017 or 2019 (https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019) on your laptop. The instructor will be using Visual Studio 2019 so that is the preferred option
    - Please download and install the AWS Toolkit for Visual Studio (https://aws.amazon.com/visualstudio/) on your laptop
    - Please download and install the .NET Core SDK as it is needed for the ASP.Net lab (https://docs.microsoft.com/en-us/dotnet/core/install/sdk?pivots=os-windows)


## DAY One.

1. EC2 \[[lecture](DayOne/D1L1-LECTURE--Intro_to_Cloud_and_EC2_Overview.pdf)\]
    - [LAB](DayOne/D1L1-LAB-GUIDE--EC2_Windows_HOL.pdf)
        - [User Data Powershell](DayOne/D1L1-LAB-SCRIPT--ec2_windows_lab_userdata.txt)
2. VPC \[[lecture](DayOne/D1L2-LECTURE--Networking_in_AWS.pdf)\]
    - [LAB](DayOne/D1L2-LAB-GUIDE--VPC_HOL.pdf)
3. Storage \[[lecture](DayOne/D1L3-LECTURE--Storage_on_AWS.pdf)\]
    - [LAB](DayOne/D1L3-LAB-GUIDE--S3_HOL.pdf)
4. IaC \[[lecture](DayOne/D1L4-LECTURE--DevOps_CloudFormation_Intro.pdf)\]
    - Create VPC 
      - [Preview CloudFormation](DayOne/D1L4-LAB-SCRIPT-1--vpc-public-private-immersionday.json)
      - [Preview Network Diagram](DayOne/D1L4-LAB-DIAGRAM--vpc-multiaz-reference.png)
      - [Launch](https://console.aws.amazon.com/cloudformation/home?region=us-west-2#/stacks/new?stackName=%3CNAME%3E-vpc-immersionday&templateURL=https://debrosse-cloudformation-templates.s3-us-west-2.amazonaws.com/immersiondays/vpc-public-private-immersionday.yml)
        - NOTE your VPC and public subnets
    - Deploy WordPress in a HA and Scalable topology
      - [Preview CloudFormation](DayOne/D1L4-LAB-SCRIPT-2--wordpress-multiaz-immersionday.json)
      - NOTE: When providing the input parameters for this template, use the VPC you created in the previous step. Your public subnets should be used for the Load Balancer, while the private subnets should be used for your database and web servers.
      - [Launch](https://console.aws.amazon.com/cloudformation/home?region=us-west-2#/stacks/new?stackName=%3CNAME%3E-wordpress-immersionday&templateURL=https://debrosse-cloudformation-templates.s3-us-west-2.amazonaws.com/immersiondays/wordpress-multiaz-immersionday.yml)

## DAY Two.

1. DevOps & .NET \[[lecture](DayTwo/D2L1--LECTURE-Devops_and_.NET.pdf)\]
    - [LAB](DayTwo/)
2. AWS SDK for .NET \[[lecture](DayTwo/D2L2-LECTURE--SDK_and_Toolkit_Configuration.pdf)\]
    - [LAB](DayTwo/D2L2-LAB-GUIDE--Setup_AWS_Toolkit_for_VS.pdf)
    - [Official User Guide](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/welcome.html)
3. ASP.NET & RDS \[[lecture](DayTwo/D2L3-LECTURE--ASP.NET_and_Amazon_RDS.pdf)\]
    - [LAB](DayTwo/D2L3-LAB-GUIDE--ASP.NET_and_Amazon_RDS.pdf)
4. Lambda & API Gateway \[[lecture](DayTwo/D2L4-LECTURE--ASP.NET_and_Lambda_API_Gateway.pdf)\]
    - [LAB 1 - .NET Serverless Web Application](DayTwo/D2L4-LAB-1-GUIDE--ASP.NET_Core_and_Serverless.pdf)
    - [LAB 2 - .NET Serverless Image Resizing](DayTwo/D2L4-LAB-2-GUIDE--NET_Core_Serveless_resize_image.pdf)
        - [Code Snippet from Page 5](DayTwo/D2L4-LAB-SCRIPT--lambda-function-handler.cs)
