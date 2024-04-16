package org.universe.Deserealizers;

import com.fasterxml.jackson.core.JsonParser;
import com.fasterxml.jackson.databind.DeserializationContext;
import com.fasterxml.jackson.databind.JsonDeserializer;
import com.fasterxml.jackson.databind.JsonNode;
import org.bson.types.ObjectId;

import java.io.IOException;

public class ObjectIdDeserializer extends JsonDeserializer<ObjectId> {

    @Override
    public ObjectId deserialize(JsonParser p, DeserializationContext ctxt) throws IOException {
        JsonNode node = (JsonNode) p.readValueAsTree().get("$oid");
        if (node != null) {
            String value = node.textValue();
            return new ObjectId(value);
        }
        return null;
    }
}
