# AWS/Slalom .NET Immersion Days

## DAY One.

1. EC2 Lecture \[[pdf](DayOne/D1L1-LECTURE--Intro_to_Cloud_and_EC2_Overview.pdf)\]
    - [LAB](DayOne/D1L1-LAB-GUIDE--EC2_Windows_HOL.pdf)
        - [User Data Powershell](DayOne/D1L1-LAB-SCRIPT--ec2_windows_lab_userdata.txt)
2. VPC \[[pdf](DayOne/D1L2-LECTURE--Networking_in_AWS.pdf)\]
    - [LAB](DayOne/D1L2-LAB-GUIDE--VPC_HOL.pdf)
3. Storage \[[pdf](DayOne/D1L3-LECTURE--Storage_on_AWS.pdf)\]
    - [LAB](DayOne/D1L3-LAB-GUIDE--S3_HOL.pdf)
4. IaC \[[pdf](DayOne/D1L4-LECTURE--DevOps_CloudFormation_Intro.pdf)\]
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

1. DevOps & .NET
    - [LAB]()
2. AWS SDK for .NET
    - [LAB]()
    - [Official User Guide](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/welcome.html)
3. ASP.NET & RDS
    - [LAB]()
4. Lambda & API Gateway
    - [LAB 1 - .NET Serverless Web Application]()
    - [LAB 2 - .NET Serverless Image Resizing]()
