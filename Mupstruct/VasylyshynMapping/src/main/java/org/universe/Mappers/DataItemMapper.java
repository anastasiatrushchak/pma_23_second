package org.universe.Mappers;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.universe.Models.ModelXML.DataItemXMLModel;
import org.universe.Models.ModelsJson.DataItemModelJson;

@Mapper
public interface DataItemMapper {

    @Mapping(target = "objectId", source = "objectId")
    @Mapping(target = "effectimeFrom", source = "effectimeFrom")
    @Mapping(target = "effectiveTo", source = "effectiveTo")
    @Mapping(target = "someUselessStuff", source = "someUselessStuff")
    DataItemXMLModel ToObjectsDataItem(DataItemModelJson dataItemModelJson);


}
