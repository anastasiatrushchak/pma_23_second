package org.universe.Mappers;

import javax.annotation.Generated;
import org.universe.Models.ModelXML.DataItemXMLModel;
import org.universe.Models.ModelsJson.DataItemModelJson;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-12T15:17:57+0300",
    comments = "version: 1.4.2.Final, compiler: javac, environment: Java 21.0.2 (Oracle Corporation)"
)
public class DataItemMapperImpl implements DataItemMapper {

    @Override
    public DataItemXMLModel ToObjectsDataItem(DataItemModelJson dataItemModelJson) {
        if ( dataItemModelJson == null ) {
            return null;
        }

        DataItemXMLModel dataItemXMLModel = new DataItemXMLModel();

        dataItemXMLModel.setObjectId( dataItemModelJson.getObjectId() );
        dataItemXMLModel.setEffectimeFrom( dataItemModelJson.getEffectimeFrom() );
        dataItemXMLModel.setEffectiveTo( dataItemModelJson.getEffectiveTo() );
        dataItemXMLModel.setSomeUselessStuff( dataItemModelJson.getSomeUselessStuff() );

        return dataItemXMLModel;
    }
}
