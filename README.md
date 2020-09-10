# .NET Core 3.1 & MongoDB & ServiceStack

A demo project using MongoDB and ServiceStack. This project was created within 5 days, including learning MongoDB, Mongo c# Driver, and ServiceStack all from zero. So, sorry about possible defects. I've tried to include some advanced query options in MongoDB. Transactions and indexes were not demonstrated. I hope, by time, I'll include those.

## Install and Use effectively
 - Install MongoDB locally or create an Atlas account at MongoDB.com
 - Download demo database and dump it at local db or remote. I did it locally, and renamed sample_mflix database to my_movie_db
 - Remove "num_mflix_comments" field from movies collection
 - Create your connection string, there is no authentication needed while working/testing locally.
 - Update AppSettings.json => "MongoUri": "&lt;Your Connection String&gt;"

 
