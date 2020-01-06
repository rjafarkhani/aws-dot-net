# AWS .NET Immersion Days

## DAY One.

1. EC2 Lecture
    - [LAB]()
2. VPC
    - [LAB]()
3. Storage
    - [LAB]()
4. IaC
    - Create VPC 
      - [Preview CloudFormation]
      - [Preview Network Diagram]
      - [Launch](https://console.aws.amazon.com/cloudformation/home?region=us-west-2#/stacks/new?stackName=%3CNAME%3E-vpc-immersionday&templateURL=https://debrosse-cloudformation-templates.s3-us-west-2.amazonaws.com/immersiondays/vpc-public-private-immersionday.yml)
        - NOTE your VPC and public subnets
    - Deploy WordPress in a HA and Scalable topology
      - [Preview CloudFormation]
      - When providing the input parameters for this template, use the VPC you created in the previous step. Your public subnets should be used for the Load Balancer, while the private subnets should be used for your database and web servers.
      - [Launch](https://console.aws.amazon.com/cloudformation/home?region=us-west-2#/stacks/new?stackName=%3CNAME%3E-wordpress-immersionday&templateURL=https://debrosse-cloudformation-templates.s3-us-west-2.amazonaws.com/immersiondays/wordpress-multiaz-immersionday.yml)

## DAY Two.

1. DevOps & .NET
    - [LAB]()
2. AWS SDK for .NET
    - [LAB]()
3. ASP.NET & RDS
    - [LAB]()
4. Lambda & API Gateway
    - [LAB]()
