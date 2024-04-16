package org.universe.Mappers;

import org.mapstruct.Mapper;
import org.mapstruct.Mapping;
import org.mapstruct.factory.Mappers;
import org.universe.Models.ModelXML.DataXMLModel;
import org.universe.Models.ModelsJson.DataModelJson;


@Mapper
public interface DataMapper {
    DataMapper INSTANCE = Mappers.getMapper(DataMapper.class);

    @Mapping(target = "identificatorId", source = "identificatorId")
    @Mapping(target = "dataItem", source = "dataItem")
    @Mapping(target = "infos", source = "info")
    DataXMLModel toDataModelJson(DataModelJson dataModelJson);


}
