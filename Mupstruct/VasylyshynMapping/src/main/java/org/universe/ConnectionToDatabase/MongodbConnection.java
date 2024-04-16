package org.universe.ConnectionToDatabase;

import com.mongodb.client.MongoClient;
import com.mongodb.client.MongoClients;

import static org.universe.Constants.DBConstants.UrlConnectionToMongoDB;

public class MongodbConnection {

    public static MongoClient connect() {
        return MongoClients.create(UrlConnectionToMongoDB);
    }

}
