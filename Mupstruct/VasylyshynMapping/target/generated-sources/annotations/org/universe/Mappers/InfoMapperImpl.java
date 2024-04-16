package org.universe.Mappers;

import java.util.ArrayList;
import java.util.List;
import javax.annotation.Generated;
import org.universe.Models.ModelXML.InfoXMLModel;
import org.universe.Models.ModelsJson.InfoModelJson;

@Generated(
    value = "org.mapstruct.ap.MappingProcessor",
    date = "2024-04-12T15:17:56+0300",
    comments = "version: 1.4.2.Final, compiler: javac, environment: Java 21.0.2 (Oracle Corporation)"
)
public class InfoMapperImpl implements InfoMapper {

    @Override
    public InfoXMLModel ToObjectsInfo(InfoModelJson infoModelJson) {
        if ( infoModelJson == null ) {
            return null;
        }

        InfoXMLModel infoXMLModel = new InfoXMLModel();

        infoXMLModel.setTwoUselessFielsd( infoModelJson.getTwoUselessFielsd() );
        infoXMLModel.setCurrentAt( infoModelJson.getCurrentAt() );
        infoXMLModel.setCurrentFrom( infoModelJson.getCurrentFrom() );
        infoXMLModel.setType( infoModelJson.getType() );
        List<String> list = infoModelJson.getThreeMoreUselessFields();
        if ( list != null ) {
            infoXMLModel.setThreeMoreUselessFields( new ArrayList<String>( list ) );
        }

        return infoXMLModel;
    }
}
