# Function to create a DynamoDB table with employee ID as primary key and ReadCapacityUnits at 100 and WriteCapacityUnits at 200

import boto3

def create_table():
    dynamodb = boto3.resource('dynamodb', region_name='us-east-1')
    table = dynamodb.create_table(
        TableName='Employee',
        KeySchema=[
            {
                'AttributeName': 'EmployeeID',
                'KeyType': 'HASH'
            }
        ],
        AttributeDefinitions=[
            {
                'AttributeName': 'EmployeeID',
                'AttributeType': 'N'
            }
        ],
        ProvisionedThroughput={
            'ReadCapacityUnits': 100,
            'WriteCapacityUnits': 200
        }
    )
    return table
