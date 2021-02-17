﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using LdtkParser;
//
//    var project = Project.FromJson(jsonString);

namespace LdtkParser.Json
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Project
    {
        [JsonProperty("__header__")]
        public Header Header { get; set; }

        [JsonProperty("jsonVersion")]
        public string JsonVersion { get; set; }

        [JsonProperty("defaultPivotX")]
        public long DefaultPivotX { get; set; }

        [JsonProperty("defaultPivotY")]
        public long DefaultPivotY { get; set; }

        [JsonProperty("defaultGridSize")]
        public long DefaultGridSize { get; set; }

        [JsonProperty("bgColor")]
        public string BgColor { get; set; }

        [JsonProperty("defaultLevelBgColor")]
        public string DefaultLevelBgColor { get; set; }

        [JsonProperty("nextUid")]
        public long NextUid { get; set; }

        [JsonProperty("minifyJson")]
        public bool MinifyJson { get; set; }

        [JsonProperty("externalLevels")]
        public bool ExternalLevels { get; set; }

        [JsonProperty("exportTiled")]
        public bool ExportTiled { get; set; }

        [JsonProperty("exportPng")]
        public bool ExportPng { get; set; }

        [JsonProperty("pngFilePattern")]
        public object PngFilePattern { get; set; }

        [JsonProperty("backupOnSave")]
        public bool BackupOnSave { get; set; }

        [JsonProperty("backupLimit")]
        public long BackupLimit { get; set; }

        [JsonProperty("worldLayout")]
        public string WorldLayout { get; set; }

        [JsonProperty("worldGridWidth")]
        public long WorldGridWidth { get; set; }

        [JsonProperty("worldGridHeight")]
        public long WorldGridHeight { get; set; }

        [JsonProperty("defs")]
        public Defs Defs { get; set; }

        [JsonProperty("levels")]
        public List<Level> Levels { get; set; }
    }

    public partial class Defs
    {
        [JsonProperty("layers")]
        public List<Layer> Layers { get; set; }

        [JsonProperty("entities")]
        public List<Entity> Entities { get; set; }

        [JsonProperty("tilesets")]
        public List<Tileset> Tilesets { get; set; }

        [JsonProperty("enums")]
        public List<Enum> Enums { get; set; }

        [JsonProperty("externalEnums")]
        public List<object> ExternalEnums { get; set; }
    }

    public partial class Entity
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("renderMode")]
        public string RenderMode { get; set; }

        [JsonProperty("showName")]
        public bool ShowName { get; set; }

        [JsonProperty("tilesetId")]
        public long? TilesetId { get; set; }

        [JsonProperty("tileId")]
        public long? TileId { get; set; }

        [JsonProperty("tileRenderMode")]
        public string TileRenderMode { get; set; }

        [JsonProperty("maxPerLevel")]
        public long MaxPerLevel { get; set; }

        [JsonProperty("limitBehavior")]
        public string LimitBehavior { get; set; }

        [JsonProperty("pivotX")]
        public double PivotX { get; set; }

        [JsonProperty("pivotY")]
        public double PivotY { get; set; }

        [JsonProperty("fieldDefs")]
        public List<FieldDef> FieldDefs { get; set; }
    }

    public partial class FieldDef
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("type")]
        public TypeUnion FieldDefType { get; set; }

        [JsonProperty("isArray")]
        public bool IsArray { get; set; }

        [JsonProperty("canBeNull")]
        public bool CanBeNull { get; set; }

        [JsonProperty("arrayMinLength")]
        public object ArrayMinLength { get; set; }

        [JsonProperty("arrayMaxLength")]
        public object ArrayMaxLength { get; set; }

        [JsonProperty("editorDisplayMode")]
        public string EditorDisplayMode { get; set; }

        [JsonProperty("editorDisplayPos")]
        public string EditorDisplayPos { get; set; }

        [JsonProperty("editorAlwaysShow")]
        public bool EditorAlwaysShow { get; set; }

        [JsonProperty("min")]
        public object Min { get; set; }

        [JsonProperty("max")]
        public object Max { get; set; }

        [JsonProperty("regex")]
        public object Regex { get; set; }

        [JsonProperty("acceptFileTypes")]
        public object AcceptFileTypes { get; set; }

        [JsonProperty("defaultOverride")]
        public DefaultOverride DefaultOverride { get; set; }
    }

    public partial class DefaultOverride
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("params")]
        public List<Param> Params { get; set; }
    }

    public partial class TypeClass
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("params")]
        public List<long> Params { get; set; }
    }

    public partial class Enum
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("values")]
        public List<Value> Values { get; set; }

        [JsonProperty("iconTilesetUid", NullValueHandling = NullValueHandling.Ignore)]
        public long? IconTilesetUid { get; set; }

        [JsonProperty("externalRelPath")]
        public object ExternalRelPath { get; set; }

        [JsonProperty("externalFileChecksum")]
        public object ExternalFileChecksum { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tileId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TileId { get; set; }

        [JsonProperty("__tileSrcRect")]
        public List<long> TileSrcRect { get; set; }
    }

    public partial class Layer
    {
        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("type")]
        public string LayerType { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("gridSize")]
        public long GridSize { get; set; }

        [JsonProperty("displayOpacity")]
        public long DisplayOpacity { get; set; }

        [JsonProperty("pxOffsetX")]
        public long PxOffsetX { get; set; }

        [JsonProperty("pxOffsetY")]
        public long PxOffsetY { get; set; }

        [JsonProperty("intGridValues")]
        public List<IntGridValue> IntGridValues { get; set; }

        [JsonProperty("autoTilesetDefUid")]
        public object AutoTilesetDefUid { get; set; }

        [JsonProperty("autoRuleGroups")]
        public List<object> AutoRuleGroups { get; set; }

        [JsonProperty("autoSourceLayerDefUid")]
        public object AutoSourceLayerDefUid { get; set; }

        [JsonProperty("tilesetDefUid")]
        public long? TilesetDefUid { get; set; }

        [JsonProperty("tilePivotX")]
        public long TilePivotX { get; set; }

        [JsonProperty("tilePivotY")]
        public long TilePivotY { get; set; }
    }

    public partial class IntGridValue
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public partial class Tileset
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("relPath")]
        public string RelPath { get; set; }

        [JsonProperty("pxWid")]
        public long PxWid { get; set; }

        [JsonProperty("pxHei")]
        public long PxHei { get; set; }

        [JsonProperty("tileGridSize")]
        public long TileGridSize { get; set; }

        [JsonProperty("spacing")]
        public long Spacing { get; set; }

        [JsonProperty("padding")]
        public long Padding { get; set; }

        [JsonProperty("savedSelections")]
        public List<object> SavedSelections { get; set; }

        [JsonProperty("cachedPixelData")]
        public CachedPixelData CachedPixelData { get; set; }
    }

    public partial class CachedPixelData
    {
        [JsonProperty("opaqueTiles")]
        public string OpaqueTiles { get; set; }

        [JsonProperty("averageColors")]
        public string AverageColors { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("app")]
        public string App { get; set; }

        [JsonProperty("doc")]
        public Uri Doc { get; set; }

        [JsonProperty("schema")]
        public Uri Schema { get; set; }

        [JsonProperty("appAuthor")]
        public string AppAuthor { get; set; }

        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Level
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("worldX")]
        public long WorldX { get; set; }

        [JsonProperty("worldY")]
        public long WorldY { get; set; }

        [JsonProperty("pxWid")]
        public long PxWid { get; set; }

        [JsonProperty("pxHei")]
        public long PxHei { get; set; }

        [JsonProperty("__bgColor")]
        public string BgColor { get; set; }

        [JsonProperty("bgColor")]
        public object LevelBgColor { get; set; }

        [JsonProperty("bgRelPath")]
        public string BgRelPath { get; set; }

        [JsonProperty("bgPos")]
        public string LevelBgPos { get; set; }

        [JsonProperty("bgPivotX")]
        public double BgPivotX { get; set; }

        [JsonProperty("bgPivotY")]
        public double BgPivotY { get; set; }

        [JsonProperty("__bgPos")]
        public BgPos BgPos { get; set; }

        [JsonProperty("externalRelPath")]
        public object ExternalRelPath { get; set; }

        [JsonProperty("layerInstances")]
        public List<LayerInstance> LayerInstances { get; set; }

        [JsonProperty("__neighbours")]
        public List<object> Neighbours { get; set; }
    }

    public partial class BgPos
    {
        [JsonProperty("topLeftPx")]
        public List<long> TopLeftPx { get; set; }

        [JsonProperty("scale")]
        public List<long> Scale { get; set; }

        [JsonProperty("cropRect")]
        public List<long> CropRect { get; set; }
    }

    public partial class LayerInstance
    {
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("__cWid")]
        public long CWid { get; set; }

        [JsonProperty("__cHei")]
        public long CHei { get; set; }

        [JsonProperty("__gridSize")]
        public long GridSize { get; set; }

        [JsonProperty("__opacity")]
        public long Opacity { get; set; }

        [JsonProperty("__pxTotalOffsetX")]
        public long PxTotalOffsetX { get; set; }

        [JsonProperty("__pxTotalOffsetY")]
        public long PxTotalOffsetY { get; set; }

        [JsonProperty("__tilesetDefUid")]
        public long? TilesetDefUid { get; set; }

        [JsonProperty("__tilesetRelPath")]
        public string TilesetRelPath { get; set; }

        [JsonProperty("levelId")]
        public long LevelId { get; set; }

        [JsonProperty("layerDefUid")]
        public long LayerDefUid { get; set; }

        [JsonProperty("pxOffsetX")]
        public long PxOffsetX { get; set; }

        [JsonProperty("pxOffsetY")]
        public long PxOffsetY { get; set; }

        [JsonProperty("intGrid")]
        public List<IntGrid> IntGrid { get; set; }

        [JsonProperty("autoLayerTiles")]
        public List<object> AutoLayerTiles { get; set; }

        [JsonProperty("seed")]
        public long Seed { get; set; }

        [JsonProperty("gridTiles")]
        public List<GridTile> GridTiles { get; set; }

        [JsonProperty("entityInstances")]
        public List<EntityInstance> EntityInstances { get; set; }
    }

    public partial class EntityInstance
    {
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        [JsonProperty("__grid")]
        public List<long> Grid { get; set; }

        [JsonProperty("__pivot")]
        public List<double> Pivot { get; set; }

        [JsonProperty("__tile", NullValueHandling = NullValueHandling.Ignore)]
        public Tile Tile { get; set; }

        [JsonProperty("defUid")]
        public long DefUid { get; set; }

        [JsonProperty("px")]
        public List<long> Px { get; set; }

        [JsonProperty("fieldInstances")]
        public List<FieldInstance> FieldInstances { get; set; }
    }

    public partial class FieldInstance
    {
        [JsonProperty("__identifier")]
        public string Identifier { get; set; }

        [JsonProperty("__value")]
        public ValueUnion Value { get; set; }

        [JsonProperty("__type")]
        public string Type { get; set; }

        [JsonProperty("defUid")]
        public long DefUid { get; set; }

        [JsonProperty("realEditorValues")]
        public List<RealEditorValue> RealEditorValues { get; set; }
    }

    public partial class RealEditorValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("params")]
        public List<string> Params { get; set; }
    }

    public partial class ValueClass
    {
        [JsonProperty("cx")]
        public long Cx { get; set; }

        [JsonProperty("cy")]
        public long Cy { get; set; }
    }

    public partial class Tile
    {
        [JsonProperty("tilesetUid")]
        public long TilesetUid { get; set; }

        [JsonProperty("srcRect")]
        public List<long> SrcRect { get; set; }
    }

    public partial class GridTile
    {
        [JsonProperty("px")]
        public List<long> Px { get; set; }

        [JsonProperty("src")]
        public List<long> Src { get; set; }

        [JsonProperty("f")]
        public long F { get; set; }

        [JsonProperty("t")]
        public long T { get; set; }

        [JsonProperty("d")]
        public List<long> D { get; set; }
    }

    public partial class IntGrid
    {
        [JsonProperty("coordId")]
        public long CoordId { get; set; }

        [JsonProperty("v")]
        public long V { get; set; }
    }

    public partial struct Param
    {
        public bool? Bool;
        public double? Double;

        public static implicit operator Param(bool Bool) => new Param { Bool = Bool };
        public static implicit operator Param(double Double) => new Param { Double = Double };
    }

    public partial struct TypeUnion
    {
        public string String;
        public TypeClass TypeClass;

        public static implicit operator TypeUnion(string String) => new TypeUnion { String = String };
        public static implicit operator TypeUnion(TypeClass TypeClass) => new TypeUnion { TypeClass = TypeClass };
    }

    public partial struct ValueUnion
    {
        public bool? Bool;
        public double? Double;
        public string String;
        public ValueClass ValueClass;

        public static implicit operator ValueUnion(bool Bool) => new ValueUnion { Bool = Bool };
        public static implicit operator ValueUnion(double Double) => new ValueUnion { Double = Double };
        public static implicit operator ValueUnion(string String) => new ValueUnion { String = String };
        public static implicit operator ValueUnion(ValueClass ValueClass) => new ValueUnion { ValueClass = ValueClass };
    }

    public partial class Project
    {
        public static Project FromJson(string json) => JsonConvert.DeserializeObject<Project>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Project self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ParamConverter.Singleton,
                TypeUnionConverter.Singleton,
                ValueUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParamConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Param) || t == typeof(Param?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new Param { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new Param { Bool = boolValue };
            }
            throw new Exception("Cannot unmarshal type Param");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Param)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            throw new Exception("Cannot marshal type Param");
        }

        public static readonly ParamConverter Singleton = new ParamConverter();
    }

    internal class TypeUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeUnion) || t == typeof(TypeUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new TypeUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TypeClass>(reader);
                    return new TypeUnion { TypeClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type TypeUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (TypeUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.TypeClass != null)
            {
                serializer.Serialize(writer, value.TypeClass);
                return;
            }
            throw new Exception("Cannot marshal type TypeUnion");
        }

        public static readonly TypeUnionConverter Singleton = new TypeUnionConverter();
    }

    internal class ValueUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueUnion) || t == typeof(ValueUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ValueUnion { Double = doubleValue };
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new ValueUnion { Bool = boolValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ValueUnion { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<ValueClass>(reader);
                    return new ValueUnion { ValueClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type ValueUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ValueClass != null)
            {
                serializer.Serialize(writer, value.ValueClass);
                return;
            }
            throw new Exception("Cannot marshal type ValueUnion");
        }

        public static readonly ValueUnionConverter Singleton = new ValueUnionConverter();
    }
}
