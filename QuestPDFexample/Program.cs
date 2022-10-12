// See https://aka.ms/new-console-template for more information


using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

var pageContent = new List<(string o1, string o2, string o3, string o4, string o5, string o6, string o7, string o8, string o9, string o10, string o11, string o12, string o13, string o14 )>()
{
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),         
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),        
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOОплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    ("03/19092022-001", "Заменитель молочного жира Эколакт. Код ТНВЭД - 1517909900. Код ОКРБ 007-2012 - ", "кг", "5","Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "Оплата за согласованную партию товара в течение 5 банковских дней с момента поставки", "ООО усметпром", "ООО усметпром", "rub","489","489","489","489","489"),          
    
};

var textStyleWithFallback = TextStyle
    .Default
    .FontFamily(Fonts.Calibri)
    .SemiBold()
    .FontSize(8)
    
        .Fallback(y => y
            .FontFamily("Microsoft YaHei")
            .SemiBold()
            .Underline(false)
            .BackgroundColor(Colors.Red.Lighten4));

Document.Create(document =>
{
    document.Page(page =>
    {
        page.DefaultTextStyle(textStyleWithFallback);
        page.Size(PageSizes.A4.Landscape());
        page.Margin(1);

        
        page.Header()
            .AlignCenter()
            .ShowOnce()
            .Decoration(decoration =>
            {
                decoration
                    .Content()
                    .AlignCenter()
                    .Row(row =>
                    {
                        row.ConstantItem(40)
                            .Padding(5)
                            .Image("C:/Users/d.karyakin/RiderProjects/QuestPDFexample/QuestPDFexample/apple-touch-icon.png");
                    });
                /*decoration
                    .Content()
                    .AlignCenter()
                   .Text(text =>
                    {
                        text.DefaultTextStyle(x => x.SemiBold()
                            .FontSize(15)
                            .FontColor(Colors.Black));
                        text.Span("ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО «БЕЛОРУССКАЯ УНИВЕРСАЛЬНАЯ ТОВАРНАЯ БИРЖА»");
                    });*/
                decoration
                    .After()
                    .Text(text =>
                    {
                        text.DefaultTextStyle(x => x.SemiBold()
                            .FontSize(15)
                            .FontColor(Colors.Black));
                        text.Span("ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО «БЕЛОРУССКАЯ УНИВЕРСАЛЬНАЯ ТОВАРНАЯ БИРЖА»");
                    });
            });

        page.Content()
            .DefaultTextStyle(textStyleWithFallback)
            //.Border(1)
            .PaddingTop(20)
            .Table(table =>
            {
                IContainer DefaultCellStyle(IContainer container, string backgroundColor)
                {
                    return container
                        .Border(1)
                        .BorderColor(Colors.Grey.Lighten1)
                        .Background(backgroundColor)
                        .PaddingHorizontal(1)
                        .AlignCenter()
                        .AlignMiddle();
                }
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(70);
                    columns.ConstantColumn(105);
                    columns.ConstantColumn(43);
                    columns.ConstantColumn(43);
                    columns.ConstantColumn(75);
                    columns.ConstantColumn(75);
                    columns.ConstantColumn(65);
                    columns.ConstantColumn(65);
                    columns.ConstantColumn(33);
                    columns.ConstantColumn(40);
                    
                    columns.ConstantColumn(60);
                    columns.ConstantColumn(60);
                    columns.ConstantColumn(45);
                    columns.ConstantColumn(60);
                });
              
                    
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Биржевая сделка (регистрационный номер)");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Наименование товара");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Единица измерения");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Количество товара");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия оплаты");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия поставки");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Продавец");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Покупатель");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Валюта платежа");
                table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Сумма биржевой сделки\n(с учетом НДС)");
            
                table.Cell().ColumnSpan(4).Element(CellStyleForHeader).AlignCenter().Text("Плата за организацию и проведение биржевых торгов\n (биржевой сбор)");
                table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Ставка биржевого сбора, %");
                table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора без НДС");
                table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма НДС");
                table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора с НДС");
                IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);


                foreach (var content in pageContent)
                {
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o1).NormalWeight();
                    table.Cell().Element(CellStyleForTable).Text(content.o2).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o3).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o4).NormalWeight();
                    table.Cell().Element(CellStyleForTable).Text(content.o5).NormalWeight();
                    table.Cell().Element(CellStyleForTable).Text(content.o6).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o7).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o8).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o9).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o10).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o11).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o12).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o13).NormalWeight();
                    table.Cell().Element(CellStyleForTable).ShowEntire().Text(content.o14).NormalWeight();
                }
                
                
                IContainer CellStyleForTable(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
            });
            

        page.Footer()
            .Height(1, Unit.Centimetre)
            .AlignCenter()
            .AlignMiddle()
            .Text(text =>
            {
                text.DefaultTextStyle(x=>x.FontSize(10));
                text.Span("Страница: ");
                text.CurrentPageNumber().FontSize(10);
                text.Span(" из ").FontColor(Colors.Red.Darken4);
                text.TotalPages().FontSize(10);
            });
    });
}).ShowInPreviewer();

static IContainer Block(IContainer container)
{
    return container
        .Border(1)
        .Background(Colors.Grey.Lighten3)
        .ShowOnce()
        .MinWidth(50)
        .MinHeight(50)
        .AlignCenter()
        .AlignMiddle();
}


/*Document.Create(document =>
{
document.Page(page =>
{
page.Margin(5);
page.Header()
    .Width(12)
    .Table(table =>
{
    table.ColumnsDefinition(columns =>
    {
        columns.ConstantColumn(50);
        columns.RelativeColumn();
        columns.ConstantColumn(50);
        columns.ConstantColumn(50);
        columns.ConstantColumn(50);
    });
    table.Header(header =>
    {
        header.Cell().Text("column");
    });
});
   



page.Content()
    .PaddingTop(20)
    .Column(column =>
    {
        column.Spacing(10);
        foreach (var i in Enumerable.Range(0, 30))
        {
            column.Item()
                .Component(new MyComponent(i));
                /*.Border(1)
                .BorderColor(Colors.Black)
                .Background(Colors.Grey.Medium)
                .Height(100);#1#
        }
    });


page.Footer()
    .Background(Colors.Green.Lighten2)
    .Height(1, Unit.Inch)
    .AlignCenter()
    .Text(text =>
    {
        text.DefaultTextStyle(x => x.FontSize(30));
        text.Span("page: ");
        text.CurrentPageNumber().FontSize(20);
        text.Span(" of ").FontColor(Colors.Red.Darken4);
        text.TotalPages().FontSize(20);
    });
});
}).ShowInPreviewer();*/

public class MyComponent : IComponent
{
    private readonly int _id;

    public MyComponent(int id)
    {
        _id = id;
    }

    public void Compose(IContainer container)
    {
        container.Text($"MyComponent {_id}");
    }
}
/*Document.Create(document =>
{
    document.Page(page =>
    {
        page.Margin(5);
        page.Header()
            .DebugArea("Header")
            .Background(Colors.Blue.Lighten2)
            .Height(1, Unit.Inch)
            ;

        page.Content()
            .PaddingTop(20)
            .DebugArea("grey box")
            .Column(column =>
            {
                column.Spacing(10);
                foreach (var i in Enumerable.Range(0, 30))
                {
                    column.Item()
                        .Border(3)
                        .BorderColor(Colors.Orange.Lighten1)
                        .Background(Colors.Grey.Medium)
                        .Height(100);
                }
            });

        /*page.Footer()
            .Background(Colors.Green.Lighten2)
            .Height(1, Unit.Inch)
            .Text(txt)
            .Underline()
            .FontSize(20)
            .SemiBold()
            .FontFamily(Fonts.TimesNewRoman)
            ;#1#
        page.Footer()
            .Background(Colors.Green.Lighten2)
            .Height(1, Unit.Inch)
            .AlignCenter()
            .Text(text =>
            {
                text.DefaultTextStyle(x=>x.FontSize(30));
                text.Span("page: ");
                text.CurrentPageNumber().FontSize(20);
                text.Span(" of ").FontColor(Colors.Red.Darken4);
                text.TotalPages().FontSize(20);
            });
    });
}).ShowInPreviewer();*/