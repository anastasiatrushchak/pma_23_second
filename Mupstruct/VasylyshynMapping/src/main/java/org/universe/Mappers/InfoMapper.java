package org.universe.Mappers;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.universe.Models.ModelXML.InfoXMLModel;
import org.universe.Models.ModelsJson.InfoModelJson;

@Mapper
public interface InfoMapper {

    @Mapping(target = "twoUselessFielsd", source = "twoUselessFielsd")
    @Mapping(target = "currentAt", source = "currentAt")
    @Mapping(target = "currentFrom", source = "currentFrom")
    @Mapping(target = "type", source = "type")
    @Mapping(target = "threeMoreUselessFields", source = "threeMoreUselessFields")
    InfoXMLModel ToObjectsInfo(InfoModelJson infoModelJson);
}
