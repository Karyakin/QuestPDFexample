// See https://aka.ms/new-console-template for more information


using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

Console.WriteLine("Hello, World!");

string txt = "Hello PDF";

var textStyleWithFallback = TextStyle
    .Default
    .FontFamily(Fonts.Calibri)
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
        page.Margin(5);

        
        /*page.Header()
            .Border(2)
            .Height(60)
            .Background(Colors.Grey.Lighten1)
            .AlignCenter()
            .AlignMiddle()
            .Text("ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО «БЕЛОРУССКАЯ УНИВЕРСАЛЬНАЯ ТОВАРНАЯ БИРЖА»");*/

        page.Content()
            .DefaultTextStyle(textStyleWithFallback)
            .Border(1)
           

            .Table(table =>
            {
                IContainer DefaultCellStyle(IContainer container, string backgroundColor)
                {
                    return container
                        .Border(1)
                        .BorderColor(Colors.Grey.Lighten1)
                        .Background(backgroundColor)
                        .PaddingVertical(1)
                        .PaddingHorizontal(10)
                        .AlignCenter()
                        .AlignMiddle();
                }
                table.ColumnsDefinition(columns =>
                {
                    columns.ConstantColumn(85);
                    columns.ConstantColumn(100);
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
        
                    columns.ConstantColumn(60);
                    columns.ConstantColumn(60);
        
                    columns.ConstantColumn(60);
                    columns.ConstantColumn(60);
                });
              
                    
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Биржевая сделка (регистрационный номер)");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Наименование товара");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Единица измерения");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Количество товара");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия оплаты");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия поставки");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Продавец");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Покупатель");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Валюта платежа");
                table.Cell().RowSpan(2).Element(CellStyle).ExtendHorizontal().AlignLeft().AlignCenter().Text("Сумма биржевой сделки (с учетом НДС");
            
                table.Cell().ColumnSpan(4).Element(CellStyle).AlignCenter().Text("Плата за организацию и проведение биржевых торгов\n (биржевой сбор)");
                table.Cell().Element(CellStyle).AlignCenter().Text("Ставка биржевого сбора, %");
                table.Cell().Element(CellStyle).AlignCenter().Text("Сумма биржевого сбора без НДС");
                table.Cell().Element(CellStyle).AlignCenter().Text("Сумма НДС");
                table.Cell().Element(CellStyle).AlignCenter().Text("Сумма биржевого сбора с НДС");
                IContainer CellStyle(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3); 
            });
            

        page.Footer()
            .Height(30)
            .Background(Colors.Grey.Lighten1)
            .AlignCenter()
            .AlignMiddle()
            .Text("Footer");
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