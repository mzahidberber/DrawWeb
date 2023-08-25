using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Draw.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IndexId = table.Column<int>(type: "INTEGER", nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    GifUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    LogoUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ResponeseType = table.Column<string>(type: "TEXT", nullable: true),
                    Header = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    Return = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IndexId = table.Column<int>(type: "INTEGER", nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    GifUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    LogoUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ResponeseType = table.Column<string>(type: "TEXT", nullable: true),
                    Header = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    Return = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: true),
                    MainTitleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titles_MainTitles_MainTitleId",
                        column: x => x.MainTitleId,
                        principalTable: "MainTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    IndexId = table.Column<int>(type: "INTEGER", nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    TextUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl1 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl2 = table.Column<string>(type: "TEXT", nullable: true),
                    ShortcutUrl3 = table.Column<string>(type: "TEXT", nullable: true),
                    GifUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    LogoUrl = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    ResponeseType = table.Column<string>(type: "TEXT", nullable: true),
                    Header = table.Column<string>(type: "TEXT", maxLength: 2000, nullable: true),
                    Return = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: true),
                    BaseTitleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTitles_Titles_BaseTitleId",
                        column: x => x.BaseTitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MainTitles",
                columns: new[] { "Id", "Body", "Explanation", "GifUrl", "Header", "IndexId", "LogoUrl", "ResponeseType", "Return", "ShortcutUrl1", "ShortcutUrl2", "ShortcutUrl3", "TextUrl1", "TextUrl2", "TextUrl3", "Title" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 0, null, null, null, null, null, null, "DrawCAD.html", null, null, "DrawCAD" },
                    { 2, null, null, null, null, 0, null, null, null, null, null, null, "File.html", null, null, "File" },
                    { 3, null, null, null, null, 0, null, null, null, null, null, null, "Commands.html", null, null, "Commands" },
                    { 4, null, null, null, null, 0, "Layer.png", null, null, null, null, null, "Layer.html", null, null, "Layer" },
                    { 5, null, null, null, null, 0, null, null, null, null, null, null, "Snaps.html", null, null, "Snaps" },
                    { 6, null, null, null, null, 0, null, null, null, null, null, null, "Handles.html", null, null, "Handles" },
                    { 7, null, null, null, null, 0, "elementInfo.png", null, null, null, null, null, "Element Information.html", null, null, "Element Information" },
                    { 8, null, null, null, null, 0, null, null, null, null, null, null, "Other.html", null, null, "Other" },
                    { 9, null, null, null, null, 2, null, null, null, null, null, null, "DrawApi.html", null, null, "DrawApi" },
                    { 10, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Draw" },
                    { 11, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "DrawBox" },
                    { 12, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Element  " },
                    { 13, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "ElementType  " },
                    { 14, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Layer  " },
                    { 15, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Pen  " },
                    { 16, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "PenStyles  " },
                    { 17, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Point  " },
                    { 18, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "PointType  " },
                    { 19, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "Radius  " },
                    { 20, null, null, null, null, 2, null, null, null, null, null, null, null, null, null, "SSAngle  " },
                    { 21, null, null, null, null, 3, null, null, null, null, null, null, "DrawGeo.html", null, null, "DrawGeo" },
                    { 22, null, null, null, null, 3, null, null, null, null, null, null, null, null, null, "Geo" },
                    { 23, null, null, null, null, 4, null, null, null, null, null, null, "DrawAuth.html", null, null, "DrawAuth" },
                    { 24, null, null, null, null, 4, null, null, null, null, null, null, null, null, null, "User" },
                    { 25, null, null, null, null, 4, null, null, null, null, null, null, null, null, null, "Auth" },
                    { 26, null, null, null, null, 1, null, null, null, null, null, null, "DrawCAD.html", null, null, "DrawCAD" },
                    { 27, null, null, null, null, 1, null, null, null, null, null, null, "api.html", null, null, "Api" },
                    { 28, null, null, null, null, 1, null, null, null, null, null, null, "client.html", null, null, "Client" },
                    { 29, null, null, null, null, 1, null, null, null, null, null, null, "geo.html", null, null, "Geo" },
                    { 30, null, null, null, null, 1, null, null, null, null, null, null, "auth.html", null, null, "Auth" },
                    { 31, null, null, null, null, 1, null, null, null, null, null, null, "data.html", null, null, "Data" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Body", "Explanation", "GifUrl", "Header", "IndexId", "LogoUrl", "MainTitleId", "ResponeseType", "Return", "ShortcutUrl1", "ShortcutUrl2", "ShortcutUrl3", "TextUrl1", "TextUrl2", "TextUrl3", "Title" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 0, null, 3, null, null, null, null, null, null, null, null, "Draw Commands" },
                    { 2, null, null, null, null, 0, null, 3, null, null, null, null, null, null, null, null, "Edit Commands" },
                    { 3, null, null, "endsnap.gif", null, 0, "closeendpoint.png", 5, null, null, "f6", null, null, "End Snap.html", null, null, "End Snap" },
                    { 4, null, null, "middlesnap.gif", null, 0, "CloseMidPoint.png", 5, null, null, "f7", null, null, "Middle Snap.html", null, null, "Middle Snap" },
                    { 5, null, null, "centersnap.gif", null, 0, "CloseCenter.png", 5, null, null, "f8", null, null, "Center Snap.html", null, null, "Center Snap" },
                    { 6, null, null, "nearestsnap.gif", null, 0, "CloseNearest.png", 5, null, null, "f9", null, null, "Nearest Snap.html", null, null, "Nearest Snap" },
                    { 7, null, null, "intersectionsnap.gif", null, 0, "CloseIntersection.png", 5, null, null, "f10", null, null, "Intersection Snap.html", null, null, "Intersection Snap" },
                    { 8, null, null, "polarmod.gif", null, 0, "ClosePain.png", 5, null, null, "f4", null, null, "Polar Mode.html", null, null, "Polar Mode" },
                    { 9, null, null, "orthomod.gif", null, 0, "CloseOrtho.png", 5, null, null, "f3", null, null, "Ortho Mode.html", null, null, "Ortho Mode" },
                    { 10, null, null, "gridsnap.gif", null, 0, "CloseGrid.png", 5, null, null, "f5", null, null, "Grid Snap.html", null, null, "Grid Snap" },
                    { 11, null, null, null, null, 0, "linewidthBtnClose.png", 8, null, null, null, null, null, "Line Width.html", null, null, "Line Width" },
                    { 12, null, null, "add.gif", null, 0, "addBtn.png", 2, null, null, null, null, null, "Add.html", null, null, "Add" },
                    { 13, null, null, "open.gif", null, 0, "openfile.png", 2, null, null, null, null, null, "Open.html", null, null, "Open" },
                    { 14, null, null, "push.gif", null, 0, "saveCloud.png", 2, null, null, null, null, null, "Push.html", null, null, "Push" },
                    { 15, null, null, "pull.gif", null, 0, "getCloud.png", 2, null, null, null, null, null, "Pull.html", null, null, "Pull" },
                    { 16, null, null, null, null, 0, null, 2, null, null, null, null, null, "Save.html", null, null, "Save" },
                    { 17, null, null, null, null, 0, null, 2, null, null, null, null, null, "Save Cloud.html", null, null, "Save Cloud" },
                    { 18, "StartCommand.json", null, null, "/Draw/startCommand", 2, null, 10, "POST", null, null, null, null, "StartCommand.html", null, null, "Start Command" },
                    { 19, "AddCoordinate.json", null, null, "/Draw/addCoordinate", 2, null, 10, "POST", null, null, null, null, "AddCoordinate.html", null, null, "Add Coordinate" },
                    { 20, null, null, null, "/Draw/stopCommand", 2, null, 10, "PUT", null, null, null, null, "StopCommand.html", null, null, "Stop Command" },
                    { 21, "SetRadius.json", null, null, "/Draw/setRadius", 2, null, 10, "PUT", null, null, null, null, "SetRadius.html", null, null, "Set Radius" },
                    { 23, null, null, null, "/Draw/setIsFinish?finish=true", 2, null, 10, "PUT", null, null, null, null, "SetIsFinish.html", null, null, "Set Is Finish" },
                    { 24, "SaveDraw.json", null, null, "/Draw/saveDraw", 2, null, 10, "POST", null, null, null, null, "SaveDraw.html", null, null, "Save Draw" },
                    { 25, "ReadDraw.json", null, null, "/Draw/readDraw", 2, null, 10, "POST", null, null, null, null, "ReadDraw.html", null, null, "Read Draw" },
                    { 26, null, null, null, "/DrawBox/drawBoxes", 2, null, 11, "GET", null, null, null, null, "DrawBoxest.html", null, null, "Draw Boxes" },
                    { 27, "DrawBoxesAdd.json", null, null, "/DrawBox/drawBoxes/add", 2, null, 11, "GET", null, null, null, null, "DrawBoxesAdd.html", null, null, "Draw Boxes Add" },
                    { 28, "DrawBoxesDelete.json", null, null, "/DrawBox/drawBoxes/delete", 2, null, 11, "DELETE", null, null, null, null, "DrawBoxesDelete.html", null, null, "Draw Boxes Delete" },
                    { 29, "DrawBoxesUpdate.json", null, null, "/DrawBox/drawBoxes/update", 2, null, 11, "PUT", null, null, null, null, "DrawBoxesUpdate.html", null, null, "Draw Boxes Update" },
                    { 30, null, null, null, "/DrawBox/drawBoxes/{id}", 2, null, 11, "GET", null, null, null, null, "DrawBoxId.html", null, null, "Draw Box" },
                    { 31, null, null, null, "/DrawBox/drawBoxes/{id}/layers", 2, null, 11, "GET", null, null, null, null, "DrawBoxIdLayers.html", null, null, "Draw Box With Layers" },
                    { 32, null, null, null, "/Element/elements", 2, null, 12, "GET", null, null, null, null, "Elementst.html", null, null, "Elements" },
                    { 33, null, null, null, "/Element/elementswithatt", 2, null, 12, "GET", null, null, null, null, "ElementsWithAtt.html", null, null, "Elements With Attributes" },
                    { 34, null, null, null, "/Element/elementsbydraw?drawId=0", 2, null, 12, "GET", null, null, null, null, "ElementsByDraw.html", null, null, "Elements By Draw" },
                    { 35, null, null, null, "/Element/elementsbydrawwithatt?drawId=0", 2, null, 12, "GET", null, null, null, null, "ElementsByDrawWithAtt.html", null, null, "Elements By Draw With Attributes" },
                    { 36, null, null, null, "/Element/elementsbylayer?layerId=0", 2, null, 12, "GET", null, null, null, null, "ElementsByLayer.html", null, null, "Elements By Layer" },
                    { 37, null, null, null, "/Element/elementsbylayerwithatt?layerId=0", 2, null, 12, "GET", null, null, null, null, "ElementsByLayerWithAtt.html", null, null, "Elements By Layer With Attributes" },
                    { 38, "ElementsAdd.json", null, null, "/Element/elements/add", 2, null, 12, "POST", null, null, null, null, "ElementsAdd.html", null, null, "Elements Add" },
                    { 39, "ElementsDelete.json", null, null, "/Element/elements/delete", 2, null, 12, "DELETE", null, null, null, null, "ElementsDelete.html", null, null, "Elements Delete" },
                    { 40, "ElementsUpdate.json", null, null, "/Element/elements/update", 2, null, 12, "PUT", null, null, null, null, "ElementsUpdate.html", null, null, "Elements Update" },
                    { 41, null, null, null, "/Element/elements/{id}", 2, null, 12, "GET", null, null, null, null, "ElementId.html", null, null, "Element" },
                    { 42, null, null, null, "/Element/elements/{id}/elementType", 2, null, 12, "GET", null, null, null, null, "ElementIdElementType.html", null, null, "Element Element Type" },
                    { 43, null, null, null, "/Element/elements/{id}/pen", 2, null, 12, "GET", null, null, null, null, "ElementIdPen.html", null, null, "Element Pen" },
                    { 44, null, null, null, "/Element/elements/{id}/layer", 2, null, 12, "GET", null, null, null, null, "ElementIdLayer.html", null, null, "Element Layer" },
                    { 45, null, null, null, "/Element/elements/{id}/radiuses", 2, null, 12, "GET", null, null, null, null, "ElementIdRadiuses.html", null, null, "Element Radiuses" },
                    { 46, null, null, null, "/Element/elements/{id}/ssangles", 2, null, 12, "GET", null, null, null, null, "ElementIdSSAngles.html", null, null, "Element SSAngles" },
                    { 47, null, null, null, "/Element/elements/{id}/points", 2, null, 12, "GET", null, null, null, null, "ElementIdPoints.html", null, null, "Element Points" },
                    { 48, null, null, null, "/ElementType/elementTypes", 2, null, 13, "GET", null, null, null, null, "ElementTypes.html", null, null, "Element Types" },
                    { 49, null, null, null, "/ElementType/elementTypes/{id}", 2, null, 13, "GET", null, null, null, null, "ElementType.html", null, null, "Element Type" },
                    { 50, "ElementTypeAdd.json", null, null, "/ElementType/elementTypes/add", 2, null, 13, "POST", null, null, null, null, "ElementTypeAdd.html", null, null, "Element Types Add" },
                    { 51, "ElementTypeDelete.json", null, null, "/ElementType/elementTypes/delete", 2, null, 13, "DELETE", null, null, null, null, "ElementTypeDelete.html", null, null, "Element Types Delete" },
                    { 52, "ElementTypeUpdate.json", null, null, "/ElementType/elementTypes/update", 2, null, 13, "PUT", null, null, null, null, "ElementTypeUpdate.html", null, null, "Element Types Update" },
                    { 53, null, null, null, "/Layer/layers", 2, null, 14, "GET", null, null, null, null, "Layers.html", null, null, "Layers" },
                    { 54, null, null, null, "/Layer/layers?drawId=0", 2, null, 14, "POST", null, null, null, null, "LayersDrawId.html", null, null, "Draw Layers" },
                    { 55, null, null, null, "/Layer/layerswithpen?drawId=0", 2, null, 14, "POST", null, null, null, null, "LayersDrawIdWithPen.html", null, null, "Draw Layers With Pen" },
                    { 56, "LayersAdd.json", null, null, "/Layer/layers/add", 2, null, 14, "POST", null, null, null, null, "LayersAdd.html", null, null, "Layers Add" },
                    { 57, "LayersDelete.json", null, null, "/Layer/layers/delete", 2, null, 14, "DELETE", null, null, null, null, "LayersDelete.html", null, null, "Layers Delete" },
                    { 58, "LayersUpdate.json", null, null, "/Layer/layers/update", 2, null, 14, "PUT", null, null, null, null, "LayersUpdate.html", null, null, "Layers Update" },
                    { 59, null, null, null, "/Layer/layers/{id}", 2, null, 14, "GET", null, null, null, null, "Layert.html", null, null, "Layer" },
                    { 60, null, null, null, "/Layer/layers/{id}/elements", 2, null, 14, "GET", null, null, null, null, "Layerelements.html", null, null, "Layer Elements" },
                    { 61, null, null, null, "/Layer/layers/{id}/pen", 2, null, 14, "GET", null, null, null, null, "Layerpen.html", null, null, "Layer Pen" },
                    { 62, null, null, null, "/Pen/pens", 2, null, 15, "GET", null, null, null, null, "Pens.html", null, null, "Pens" },
                    { 63, null, null, null, "/Pen/penswithatt", 2, null, 15, "GET", null, null, null, null, "Penswithatt.html", null, null, "Pens With Attributes" },
                    { 64, null, null, null, "/Pen/pens/{id}", 2, null, 15, "GET", null, null, null, null, "Pent.html", null, null, "Pen" },
                    { 65, null, null, null, "/Pen/pens/{id}/penstyle", 2, null, 15, "GET", null, null, null, null, "Penpenstyle.html", null, null, "Pen PenStyle" },
                    { 66, "Pensadd.json", null, null, "/Pen/pens/add", 2, null, 15, "POST", null, null, null, null, "Penadd.html", null, null, "Pen Add" },
                    { 67, "Pensdelete.json", null, null, "/Pen/pens/delete", 2, null, 15, "DELETE", null, null, null, null, "Pendelete.html", null, null, "Pen Delete" },
                    { 68, "Pensupdate.json", null, null, "/Pen/pens/update", 2, null, 15, "PUT", null, null, null, null, "Penupdate.html", null, null, "Pen Update" },
                    { 69, null, null, null, "/PenStyles/penstyles", 2, null, 16, "GET", null, null, null, null, "PenStyles.html", null, null, "PenStyles" },
                    { 70, null, null, null, "/PenStyles/penstyles/{id}", 2, null, 16, "GET", null, null, null, null, "Penstylet.html", null, null, "PenStyle" },
                    { 71, "Penstyleadd.json", null, null, "/PenStyles/penstyles/add", 2, null, 16, "POST", null, null, null, null, "Penstylesadd.html", null, null, "PenStyles Add" },
                    { 72, "Penstyledelete.json", null, null, "/PenStyles/penstyles/delete", 2, null, 16, "DELETE", null, null, null, null, "Penstylesdelete.html", null, null, "PenStyles Delete" },
                    { 73, "Penstyleupdate.json", null, null, "/PenStyles/penstyles/update", 2, null, 16, "PUT", null, null, null, null, "Penstylesupdate.html", null, null, "PenStyles Update" },
                    { 74, null, null, null, "/Point/points", 2, null, 17, "GET", null, null, null, null, "Points.html", null, null, "Points" },
                    { 75, null, null, null, "/Point/pointsbyelement?elementId=0", 2, null, 17, "GET", null, null, null, null, "Pointsbyelement.html", null, null, "Points By Element" },
                    { 76, null, null, null, "/Point/pointsbylayer?layerId=0", 2, null, 17, "GET", null, null, null, null, "Pointsbylayer.html", null, null, "Points By Layer" },
                    { 77, null, null, null, "/Point/pointsbydraw?drawId=0", 2, null, 17, "GET", null, null, null, null, "Pointsbydraw.html", null, null, "Points By Draw" },
                    { 78, "Pointsadd.json", null, null, "/Point/points/add", 2, null, 17, "GET", null, null, null, null, "Pointsadd.html", null, null, "Points Add" },
                    { 79, "Pointsdelete.json", null, null, "/Point/points/delete", 2, null, 17, "DELETE", null, null, null, null, "Pointsdelete.html", null, null, "Points Delete" },
                    { 80, "Pointsupdate.json", null, null, "/Point/points/update", 2, null, 17, "PUT", null, null, null, null, "Pointsupdate.html", null, null, "Points Update" },
                    { 81, null, null, null, "/Point/points/{id}", 2, null, 17, "GET", null, null, null, null, "Pointt.html", null, null, "Point" },
                    { 82, null, null, null, "/Point/points/{id}/element", 2, null, 17, "GET", null, null, null, null, "Pointelement.html", null, null, "Point Element" },
                    { 83, null, null, null, "/Point/points/{id}/pointtype", 2, null, 17, "GET", null, null, null, null, "Pointpointtype.html", null, null, "Point PointType" },
                    { 84, null, null, null, "/PointType/pointtypes", 2, null, 18, "GET", null, null, null, null, "PointTypes.html", null, null, "PointTypes" },
                    { 85, null, null, null, "/PointType/pointtypes/{id}", 2, null, 18, "GET", null, null, null, null, "PointType.html", null, null, "PointType" },
                    { 86, "pointtypeadd.json", null, null, "/PointType/pointtypes/add", 2, null, 18, "POST", null, null, null, null, "PointTypeadd.html", null, null, "PointType Add" },
                    { 87, "pointtypedelete.json", null, null, "/PointType/pointtypes/delete", 2, null, 18, "DELETE", null, null, null, null, "PointTypedelete.html", null, null, "PointType Delete" },
                    { 88, "pointtypeupdate.json", null, null, "/PointType/pointtypes/update", 2, null, 18, "PUT", null, null, null, null, "PointTypeupdate.html", null, null, "PointType Update" },
                    { 89, null, null, null, "/Radius/radiuses", 2, null, 19, "GET", null, null, null, null, "Radiuses.html", null, null, "Radiuses" },
                    { 90, "radiusesadd.json", null, null, "/Radius/radiuses/add", 2, null, 19, "POST", null, null, null, null, "Radiusesadd.html", null, null, "Radiuses Add" },
                    { 91, "radiusesdelete.json", null, null, "/Radius/radiuses/delete", 2, null, 19, "DELETE", null, null, null, null, "Radiusesdelete.html", null, null, "Radiuses Delete" },
                    { 92, "radiusesupdate.json", null, null, "/Radius/radiuses/update", 2, null, 19, "PUT", null, null, null, null, "Radiusesupdate.html", null, null, "Radiuses Update" },
                    { 93, null, null, null, "/Radius/radiuses/{id}", 2, null, 19, "GET", null, null, null, null, "Radiuset.html", null, null, "Radiuse" },
                    { 94, null, null, null, "/SSAngle/ssangles/{id}", 2, null, 20, "GET", null, null, null, null, "SSAnglet.html", null, null, "SSAngle" },
                    { 95, null, null, null, "/SSAngle/ssangles", 2, null, 20, "GET", null, null, null, null, "SSAngles.html", null, null, "SSAngles" },
                    { 96, "SSAnglesadd.json", null, null, "/SSAngle/ssangles/add", 2, null, 20, "POST", null, null, null, null, "SSAnglesadd.html", null, null, "SSAngles Add" },
                    { 97, "SSAnglesdelete.json", null, null, "/SSAngle/ssangles/delete", 2, null, 20, "DELETE", null, null, null, null, "SSAnglesdelete.html", null, null, "SSAngles Delete" },
                    { 98, "SSAnglesupdate.json", null, null, "/SSAngle/ssangles/update", 2, null, 20, "PUT", null, null, null, null, "SSAnglesupdate.html", null, null, "SSAngles Update" },
                    { 99, "findTwoPointsLength.json", null, null, "/findTwoPointsLength/", 3, null, 22, "POST", null, null, null, null, "findTwoPointsLength.html", null, null, "Find Two Point Length" },
                    { 100, "findCenterAndRadius.json", null, null, "/findCenterAndRadius/", 3, null, 22, "POST", null, null, null, null, "findCenterAndRadius.html", null, null, "Find Center And Radius" },
                    { 101, "findToSlopeLine.json", null, null, "/findToSlopeLine/", 3, null, 22, "POST", null, null, null, null, "findToSlopeLine.html", null, null, "Find To Slope Line" },
                    { 102, "findDegreeLineSlope.json", null, null, "/findDegreeLineSlope/", 3, null, 22, "POST", null, null, null, null, "findDegreeLineSlope.html", null, null, "Find Degree Line Slope" },
                    { 103, "findDegreeLineTwoPoints.json", null, null, "/findDegreeLineTwoPoints/", 3, null, 22, "POST", null, null, null, null, "findDegreeLineTwoPoints.html", null, null, "Find Degree Line Two Points" },
                    { 104, "convertDegreeToSlope.json", null, null, "/convertDegreeToSlope/", 3, null, 22, "POST", null, null, null, null, "convertDegreeToSlope.html", null, null, "Convert Degree To Slope" },
                    { 105, "convertRadianToDegree.json", null, null, "/convertRadianToDegree/", 3, null, 22, "POST", null, null, null, null, "convertRadianToDegree.html", null, null, "Convert Radian To Degree" },
                    { 106, "convertDegreeToRadians.json", null, null, "/convertDegreeToRadians/", 3, null, 22, "POST", null, null, null, null, "convertDegreeToRadians.html", null, null, "Convert Degree To Radians" },
                    { 107, "findCenterPointToLine.json", null, null, "/findCenterPointToLine/", 3, null, 22, "POST", null, null, null, null, "findCenterPointToLine.html", null, null, "Find Center Point To Line" },
                    { 108, "findDegreeToBetweenTwoLines.json", null, null, "/findDegreeToBetweenTwoLines/", 3, null, 22, "POST", null, null, null, null, "findDegreeToBetweenTwoLines.html", null, null, "Find Degree To Between Two Lines" },
                    { 109, "findDotProductToTwoPoints.json", null, null, "/findDotProductToTwoPoints/", 3, null, 22, "POST", null, null, null, null, "findDotProductToTwoPoints.html", null, null, "Find Dot Product To Two Points" },
                    { 110, "findDifferenceTwoPoints.json", null, null, "/findDifferenceTwoPoints/", 3, null, 22, "POST", null, null, null, null, "findDifferenceTwoPoints.html", null, null, "Find Difference Two Points" },
                    { 111, "wherePointOnLine.json", null, null, "/wherePointOnLine/", 3, null, 22, "POST", null, null, null, null, "wherePointOnLine.html", null, null, "Where Point On Line" },
                    { 112, "findInsectionPointToTwoLines.json", null, null, "/findInsectionPointToTwoLines/", 3, null, 22, "POST", null, null, null, null, "findInsectionPointToTwoLines.html", null, null, "Find Insection Point To Two Lines" },
                    { 113, "findPointLength.json", null, null, "/findPointLength/?length=0", 3, null, 22, "POST", null, null, null, null, "findPointLength.html", null, null, "Find Point Length" },
                    { 114, "wherePointZone.json", null, null, "/wherePointZone/", 3, null, 22, "POST", null, null, null, null, "wherePointZone.html", null, null, "Where Point Zone" },
                    { 115, "findNearetPoint.json", null, null, "/findNearetPoint/", 3, null, 22, "POST", null, null, null, null, "findNearetPoint.html", null, null, "Find Nearest Point" },
                    { 116, "findStartAndStopAngle.json", null, null, "/findStartAndStopAngle/", 3, null, 22, "POST", null, null, null, null, "findStartAndStopAngle.html", null, null, "Find Start And Stop Angle" },
                    { 117, "findStartAndStopAngleTwoPoint.json", null, null, "/findStartAndStopAngleTwoPoint/", 3, null, 22, "POST", null, null, null, null, "findStartAndStopAngleTwoPoint.html", null, null, "Find Start And Stop Angle Two Point" },
                    { 118, "findPointOnCircle.json", null, null, "/findPointOnCircle/", 3, null, 22, "POST", null, null, null, null, "findPointOnCircle.html", null, null, "Find Point On Circle" },
                    { 119, "createuser.json", null, null, "/User/createuser", 4, null, 24, "POST", null, null, null, null, "createuser.html", null, null, "Create User" },
                    { 120, null, null, null, "/User/getuser", 4, null, 24, "GET", null, null, null, null, "getuser.html", null, null, "Get User" },
                    { 121, "createtoken.json", null, null, "/Auth/createtoken", 4, null, 25, "POST", null, null, null, null, "createtoken.html", null, null, "Create Token" },
                    { 122, "createtokenbyrefreshtoken.json", null, null, "/Auth/createtokenbyrefreshtoken", 4, null, 25, "POST", null, null, null, null, "createtokenbyrefreshtoken.html", null, null, "Create Token By Refresh Token" },
                    { 123, "revokerefreshtoken.json", null, null, "/Auth/revokerefreshtoken", 4, null, 25, "POST", null, null, null, null, "revokerefreshtoken.html", null, null, "Revoke Refresh Token" },
                    { 124, null, null, null, null, 1, null, 27, null, null, null, null, null, "apilayer.html", null, null, "Api" },
                    { 125, null, null, null, null, 1, null, 27, null, null, null, null, null, "businesslayer.html", null, null, "Business" },
                    { 126, null, null, null, null, 1, null, 27, null, null, null, null, null, "dataaccesslayer.html", null, null, "DataAccess" },
                    { 127, null, null, null, null, 1, null, 27, null, null, null, null, null, "drawlayer.html", null, null, "DrawLayer" },
                    { 128, null, null, null, null, 1, null, 27, null, null, null, null, null, "corelayer.html", null, null, "Core" }
                });

            migrationBuilder.InsertData(
                table: "SubTitles",
                columns: new[] { "Id", "BaseTitleId", "Body", "Explanation", "GifUrl", "Header", "IndexId", "LogoUrl", "ResponeseType", "Return", "ShortcutUrl1", "ShortcutUrl2", "ShortcutUrl3", "TextUrl1", "TextUrl2", "TextUrl3", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, null, "line.gif", null, 0, "Line.png", null, null, "l", "enter", null, "Line.html", null, null, "Line" },
                    { 2, 1, null, null, "polyline.gif", null, 0, "polyline.png", null, null, "p", "o", "enter", "Polyline.html", null, null, "Polyline" },
                    { 3, 1, null, null, "rectangle.gif", null, 0, "Rectangle.png", null, null, "r", "enter", null, "Rectangle.html", null, null, "Rectangle" },
                    { 4, 1, null, null, "centerpointcircle.gif", null, 0, "CenterPointCircle.png", null, null, "c", "enter", null, "Circle Center Point.html", null, null, "Circle Center Point" },
                    { 5, 1, null, null, "treepointcircle.gif", null, 0, "treepointcircle.png", null, null, null, null, null, "Circle Tree Point.html", null, null, "Circle Tree Point" },
                    { 6, 1, null, null, "twopointcircle.gif", null, 0, "TwoPointCircle.png", null, null, null, null, null, "Circle Two Point.html", null, null, "Circle Two Point" },
                    { 7, 1, null, null, "centerradiuscircle.gif", null, 0, "Circle.png", null, null, null, null, null, "Circle Center Radius.html", null, null, "Circle Center Radius" },
                    { 8, 1, null, null, "treepointarc.gif", null, 0, "treepointarc.png", null, null, "a", "enter", null, "Arc Tree Point.html", null, null, "Arc Tree Point" },
                    { 9, 1, null, null, "twopointarc.gif", null, 0, "TwoPointCenterArc.png", null, null, null, null, null, "Arc Two Point.html", null, null, "Arc Two Point" },
                    { 10, 1, null, null, "ellipse.gif", null, 0, "Ellips.png", null, null, "e", "enter", null, "Ellipse.html", null, null, "Ellipse" },
                    { 11, 2, null, null, "move.gif", null, 0, "move.png", null, null, "m", "enter", null, "Move.html", null, null, "Move" },
                    { 12, 2, null, null, "copy.gif", null, 0, "Copy.png", null, null, "c", "o", "enter", "Copy.html", null, null, "Copy" },
                    { 13, 2, null, null, "rotate.gif", null, 0, "Rotate.png", null, null, "r", "o", "enter", "Rotate.html", null, null, "Rotate" },
                    { 14, 2, null, null, "scale.gif", null, 0, "Scale.png", null, null, "s", "enter", null, "Scale.html", null, null, "Scale" },
                    { 15, 2, null, null, "mirror.gif", null, 0, "Mirror.png", null, null, "m", "i", "enter", "Mirror.html", null, null, "Mirror" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTitles_BaseTitleId",
                table: "SubTitles",
                column: "BaseTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_MainTitleId",
                table: "Titles",
                column: "MainTitleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTitles");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "MainTitles");
        }
    }
}
