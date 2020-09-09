# .NET Core 3.1 & MongoDB & ServiceStack

A demo project using MongoDB and ServiceStack.

## Install and Use effectively
 - Install MongoDB locally or create an Atlas account at MongoDB.com
 - Download demo database and dump it at local db or remote. I did it locally, and renamed sample_mflix database to my_movie_db
 - Remove "num_mflix_comments" field from movies collection
 - Create your connection string, there is no authentication needed while working/testing locally.
 - Update AppSettings.json => "MongoUri": "<Your Connection String>"
 
