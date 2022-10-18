using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;


var textStyleWithFallback = TextStyle
    .Default
    .FontFamily(Fonts.Calibri)
    .SemiBold()
    .FontSize(6)
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
            .ShowOnce()
            .PaddingTop(20)
            .Column(column =>
            {
                column.Item()
                    .AlignRight()
                    .Row(row =>
                    {
                        row.ConstantItem(250)
                            .AlignRight()
                            .PaddingRight(10)
                            .Text("Приложение № 1")
                            .FontSize(10)
                            .FontFamily(Fonts.Calibri)
                            .NormalWeight();
                    });
                column.Item()
                    .AlignRight()
                    .Row(row =>
                    {
                        row.ConstantItem(250)
                            .AlignRight()
                            .PaddingTop(-4)
                            .PaddingRight(10)
                            .Text("к Публичному договору на биржевое обслуживание")
                            .FontSize(10)
                            .FontFamily(Fonts.Calibri)
                            .NormalWeight();
                    });
            });


        page.Content()
            .PaddingTop(10)
            .Grid(grid =>
            {
                grid.AlignLeft();
                grid.Columns(10);
                grid.Item(3)
                    .PaddingLeft(10)
                    .Text("Дата фиксации сделки – <dd.mm.yyyy>")
                    .FontSize(10)
                    .FontFamily(Fonts.Calibri)
                    .NormalWeight();


                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(10)
                    .PaddingBottom(20)
                    .Table(table =>
                    {
                        IContainer DefaultCellStyle(IContainer container)
                        {
                            return container
                                .Border(1)
                                .BorderColor(Colors.Grey.Lighten1)
                                .PaddingHorizontal(1)
                                .AlignCenter()
                                .AlignMiddle();
                        }

                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(70);
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(43);
                            columns.ConstantColumn(43);
                            columns.ConstantColumn(70);
                            columns.ConstantColumn(72);
                            columns.ConstantColumn(65);
                            columns.ConstantColumn(65);
                            columns.ConstantColumn(35);
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(55);
                            columns.ConstantColumn(100);


                            /*1*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Регистрационный номер сделки").NormalWeight();
                            /*2*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Наименование товара").NormalWeight();
                            /*3*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Количество").NormalWeight();
                            /*4*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Ед.изм").NormalWeight();
                            /*5*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Цена (без НДС)").NormalWeight();
                            /*6*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Валюта").NormalWeight();
                            /*7*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Ставка НДС(%)").NormalWeight();
                            /*8*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Стоимость\n (с учетом НДС)").NormalWeight();
                            /*9*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Сумма НДС)").NormalWeight();
                            /*10*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Способ доставки").NormalWeight();
                            /*11*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Срок доставки").NormalWeight();
                            /*11*/ table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия оплаты").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                            
                        });
                        
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(70);
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(43);
                            columns.ConstantColumn(43);
                            columns.ConstantColumn(70);
                            columns.ConstantColumn(72);
                            columns.ConstantColumn(65);
                            columns.ConstantColumn(65);
                            columns.ConstantColumn(35);
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(55);
                            columns.ConstantColumn(100);


                            /*1*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*2*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*3*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*4*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*5*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*6*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*7*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*8*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*9*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*10*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*11*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            /*11*/ table.Cell().Element(CellStyleForTable).ExtendHorizontal().AlignLeft().AlignCenter().Text($"?").NormalWeight();
                            
                            IContainer CellStyleForTable(IContainer container) => DefaultCellStyle(container).ShowOnce();

                        });
                        
                    });


                grid.Item(10)
                    .Element(CellStyleForTextContent)
                    .Text(text =>
                    {
                        text.Span("Описание товара: ");
                        text.Span("?????????????????????????????????")
                            .Italic();
                    });

                grid.Item(10)
                    .Element(CellStyleForTextContent)
                    .Text(text =>
                    {
                        text.Span("Адрес доставки/Адрес пункта выдачи/Местонахождение товара: ");
                        text.Span("?????????????????????????????????")
                            .Italic();
                    });
                
                grid.Item(10)
                    .Element(CellStyleForTextContent)
                    .Text(text =>
                    {
                        text.Span("Дополнительная информация: ");
                        text.Span("?????????????????????????????????")
                            .Italic();
                    });
                IContainer DefaultCellStyleText(IContainer container)
                {
                    return container
                        .PaddingLeft(10)
                        .AlignMiddle();
                }
                IContainer CellStyleForTextContent(IContainer container) => DefaultCellStyleText(container).ShowOnce();
                
                grid.Item(1)
                    .PaddingTop(20)
                    .PaddingLeft(10)
                    .Text("По сделке")
                    .FontFamily(Fonts.Calibri)
                    .NormalWeight()
                    .Italic();
                
               grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(10)
                    .PaddingBottom(20)
                    .Table(table =>
                    {
                        IContainer DefaultCellStyle(IContainer container)
                        {
                            return container
                                .Border(1)
                                .BorderColor(Colors.Grey.Lighten1)
                                .PaddingHorizontal(1)
                                .AlignCenter()
                                .AlignMiddle();
                        }
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(300);
                            columns.ConstantColumn(420);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("ИТОГО:").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("????");
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("????");
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(300);
                            columns.ConstantColumn(420);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Общая стоимость с НДС").NormalWeight().Italic();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Общая стоимость с НДС прописью").NormalWeight().Italic();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(300);
                            columns.ConstantColumn(420);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("?????");
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("?????");
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(100);
                            columns.ConstantColumn(300);
                            columns.ConstantColumn(420);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Ставка НДС").NormalWeight().Italic();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Сумма НДС прописью").NormalWeight().Italic();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                    });
               grid.Item(10)
                   .Element(CellStyleForTextContent)
                   .Text(text =>
                   {
                       text.Span("Срок действия настоящей спецификации истекает $DATE_EXPIRE ").NormalWeight();
                       text.Span("(включает контрольный срок для совершения оплаты).")
                           .Italic()
                           .NormalWeight();
                   });
                
               
                grid.Item(10)
                    .PaddingTop(20)
                    .PaddingLeft(10)
                    .PaddingRight(10)
                    .PaddingBottom(20)
                    .Table(table =>
                    {
                        IContainer DefaultCellStyle(IContainer container)
                        {
                            return container
                                //.Border(1)
                                .BorderColor(Colors.Grey.Lighten1)
                                .PaddingHorizontal(1)
                                .AlignCenter()
                                .AlignMiddle();
                        }
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);
                            
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("ПРОДАВЕЦ").Bold().FontSize(10);
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("ПОКУПАТЕЛЬ").FontSize(10);
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("$SELLER_FIRM_NAME or $SELLER_CLIENT_NAME").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("$BUYER_FULL_NAME ").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("Юридический адрес: ").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("Место жительства и (или) место пребывания: ").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("$SELLER_ADDRESS").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("$BUYER_ADDRESS_RESIDENCE").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);

                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("УНП: $SELLER_TAX_NUMBER").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("Тел.: $BUYER_TELEPHONE").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);
                            
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("Расчетный счет: $SELLER_BANK_ACCOUNTS").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("e-mail: $BUYER_MAIL").NormalWeight();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);
                            
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("Тел.: $SELLER_TELEPHONE").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(330);
                            columns.ConstantColumn(150);
                            columns.ConstantColumn(330);
                            
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().Text("e-mail: $SELLER_MAIL").NormalWeight();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            table.Cell().Element(CellStyleForHeader).ExtendHorizontal();
                            IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container);
                        });
                    });
               
               
               
               
            });
        
        

        page.Footer()
            .Height(1, Unit.Centimetre)
            .AlignRight()
            .PaddingRight(10)
            .AlignMiddle()
            .Text(text =>
            {
                text.DefaultTextStyle(x => x.FontSize(6));
                text.Span("Страница: ");
                text.CurrentPageNumber().FontSize(6);
                text.Span(" из ");
                text.TotalPages().FontSize(6);
            });
    });
}).ShowInPreviewer();


#region DealsRegisterPdf

/*using QuestPDF.Drawing;
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
    .FontSize(6)
    .Fallback(y => y
        .FontFamily("Microsoft YaHei")
        .SemiBold()
        .Underline(false)
        .BackgroundColor(Colors.Red.Lighten4));


Document.Create(document =>
{
    //DocumentMetadata.Default.ImageQuality = 50;

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
                    .PaddingTop(10)
                    .Text(text =>
                    {
                        text.DefaultTextStyle(x => x.Light()
                            .FontSize(9)
                            .FontColor(Colors.Black));
                        text.Span("ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО «БЕЛОРУССКАЯ УНИВЕРСАЛЬНАЯ ТОВАРНАЯ БИРЖА»");
                    });
            });

        
        
        page.Content()
            .PaddingTop(10)
            .Grid(grid =>
            {
                grid.AlignCenter();
                grid.Columns(10); 
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(600)
                    .Text("Получатель: ОАО «Белорусская универсальная товарная биржа», УНП 190542056\r\nСчет №: BY23AKBB30120000059140000000, банк получателя: ОАО «АСБ Беларусбанк», пр. Дзержинского, 18, БИК AKBBBY2X")
                    .NormalWeight();
                
                grid.Item(10).PaddingTop(20).PaddingBottom(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        columns.ConstantColumn(350);
                        columns.RelativeColumn();
                      
                        table.Cell()
                            .AlignMiddle()
                            .PaddingLeft(100)
                            .Text("Секция 03")
                            .FontSize(9);
                        
                        table.Cell()
                            .AlignCenter()
                            .Text("РЕЕСТР СДЕЛОК УЧАСТНИКА БИРЖЕВОЙ ТОРГОВЛИ")
                            .FontSize(14)
                            .SemiBold();
                        
                        table.Cell()
                            .AlignMiddle()
                            .AlignRight()
                            .PaddingRight(100)
                            .Text("116768")
                            .FontSize(9);
                    });
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(430)
                    .Text("Тестовый биржевой брокер. РЕСПУБЛИКА БЕЛАРУСЬ, 220005, г. Минск, ул. Платонова дом 20Б корпус 3 квартира/офис 148. 100172248. Договор на биржевое обслуживание биржевого брокера №454 от 10.12.2021, Договор на биржевое обслуживание посетителя торгов №401 от 01.09.2021");
                grid.Item(10).Column(column =>
                {
                    column.Item()
                        .PaddingLeft(10)
                        .PaddingRight(430)
                        .LineHorizontal(1)
                        .LineColor(Colors.Black);
                        
                    column.Item()
                        .PaddingRight(430)
                        .PaddingBottom(5)
                        .AlignCenter()
                        .Text("(полное наименование участника биржевой торговли, его местонахождение, УНП, № и дата договора на биржевое обслуживание)")
                        .Light()
                        .Italic()
                        .FontSize(6);
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(430)
                    .Text("000138210");
                grid.Item(10).Column(column =>
                {
                    column.Item()
                        .PaddingLeft(10)
                        .PaddingRight(430)
                        .LineHorizontal(1)
                        .LineColor(Colors.Black);
                        
                    column.Item()
                        .PaddingRight(430)
                        .PaddingBottom(5)
                        .AlignCenter()
                        .Text("(регистрационный номер участника биржевой торговли)")
                        .Light()
                        .Italic()
                        .FontSize(6);
                });
            
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(430)
                    .Text("г.Минск, ул. Казинца 666");
                
                grid.Item(10).Column(column =>
                {
                    column.Item()
                        .PaddingLeft(10)
                        .PaddingRight(430)
                        .LineHorizontal(1)
                        .LineColor(Colors.Black);
                        
                    column.Item()
                        .PaddingRight(430)
                        .PaddingBottom(10)
                        .AlignCenter()
                        .Text("(краткое наименование обособленного подразделения и его местонахождение, УНП, регистрационный номер)")
                        .Light()
                        .Italic()
                        .FontSize(6);
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingBottom(20)
                    .Table(table => {
                    IContainer DefaultCellStyle(IContainer container/*, string backgroundColor)
                    {
                        return container
                            .Border(1)
                            .BorderColor(Colors.Grey.Lighten1)
                            //.Background(backgroundColor)
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
                        columns.ConstantColumn(73);
                        columns.ConstantColumn(72);
                        columns.ConstantColumn(65);
                        columns.ConstantColumn(65);
                        columns.ConstantColumn(33);
                        columns.ConstantColumn(40);
                        
                        columns.ConstantColumn(55);
                        columns.ConstantColumn(55);
                        columns.ConstantColumn(45);
                        columns.ConstantColumn(55);
                      
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Биржевая сделка (регистрационный номер)").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Наименование товара").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Единица измерения").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Количество товара").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия оплаты").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Условия поставки").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Продавец").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Покупатель").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Валюта платежа").NormalWeight();
                        table.Cell().RowSpan(2).Element(CellStyleForHeader).ExtendHorizontal().AlignLeft().AlignCenter().Text("Сумма биржевой сделки\n(с учетом НДС)").NormalWeight();
                        IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container/*, Colors.Grey.Lighten3);
                      
                        table.Cell().ColumnSpan(4).Element(CellStyleForHeader).AlignCenter().Text("Плата за организацию и проведение биржевых торгов\n (биржевой сбор)").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Ставка биржевого сбора, %").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора без НДС").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма НДС").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора с НДС").NormalWeight();
                        
                        table.ColumnsDefinition(columnsDig => {
                        columnsDig.ConstantColumn(70);
                        columnsDig.ConstantColumn(100);
                        columnsDig.ConstantColumn(43);
                        columnsDig.ConstantColumn(43);
                        columnsDig.ConstantColumn(75);
                        columnsDig.ConstantColumn(75);
                        columnsDig.ConstantColumn(65);
                        columnsDig.ConstantColumn(65);
                        columnsDig.ConstantColumn(33);
                        columnsDig.ConstantColumn(40);
                        columnsDig.ConstantColumn(55);
                        columnsDig.ConstantColumn(55);
                        columnsDig.ConstantColumn(45);
                        columnsDig.ConstantColumn(55);
                        
                        table.Cell().Element(CellStyleForHeaderDigit).Text("1").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("2").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("3").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("4").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("5").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("6").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("7").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("8").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("9").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("10").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("11").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("12").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("13").NormalWeight();
                        table.Cell().Element(CellStyleForHeaderDigit).Text("14").NormalWeight();
                        
                        IContainer CellStyleForHeaderDigit(IContainer container) => DefaultCellStyle(container/*, Colors.Grey.Lighten3);
                        
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("02.11102022.000058").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("Балансы лиственных пород, Еденица измерения куб.м, Порода Липа, Сертификат FSC,PEFS, Сорт 1,2,3, Стандарт СТБ 1667-2012, Стандарт определения качества СТБ 1712-2007, Стандартизированное значение длины 0,75 и кратн. до 6,0, Стандартизированный диаметр 6-24, ТН ВЭД ЕАЭС 4403").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("gggggggggggggggggggggg").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Xggggggggggggggg").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("100% предоплаты на счет биржи в течение 3 банковских дней с момента получения уведомления об акцепте/принятии оферты").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("Xggggggggggggg").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Xgggggggggggggggg").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Xggggggggggggggg").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("RUB").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("1385.33").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Xsdc").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        IContainer CellStyleForTable(IContainer container) => DefaultCellStyle(container/*, Colors.White).ShowOnce();
                    });
                        
                    });
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(100);
                        columns.ConstantColumn(43);
                        columns.ConstantColumn(43);
                        columns.ConstantColumn(75);
                        columns.ConstantColumn(75);
                        columns.ConstantColumn(65);
                        columns.ConstantColumn(65);
                        columns.ConstantColumn(33);
                        columns.ConstantColumn(40);
                        columns.ConstantColumn(55);
                        columns.ConstantColumn(55);
                        columns.ConstantColumn(45);
                        columns.ConstantColumn(55);
                        
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Итого").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("RUB").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("183 000,00").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        IContainer CellStyleForTable(IContainer container) => DefaultCellStyle(container/*, Colors.White).ShowOnce();
                    });
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .Text("1 358,50 ( одна тысяча триста пятьдесят восемь ) российских рублей 50 копеек");
                
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(10)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(сумма прописью)")
                            .Italic()
                            .FontSize(6)
                            .Light();
                    });
                    
                    grid.Item(10)
                        .PaddingTop(10)
                        .PaddingLeft(10)
                        .Text("Всего сумма к оплате за услуги по организации и проведению биржевых торгов (биржевой сбор) составляет")
                        .Light();
                
                    grid.Item(10)
                        .PaddingLeft(10)
                        .Text("0,13 BYN ( ноль ) белорусских рублей 13 копеек");
                    
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(10)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(сумма прописью)")
                            .Italic()
                            .FontSize(6)
                            .Light();
                    });
                    
                    grid.Item(10)
                        .AlignLeft()
                        .PaddingLeft(10)
                        .PaddingTop(10)
                        .AlignLeft()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(140);
                                columns.ConstantColumn(25);
                                columns.RelativeColumn();
                            
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("В том числе НДС по ставке")
                                    .Light();
                                
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("200%");
                                
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("0,02 BYN ( ноль ) белорусских рублей 02 копейки");
                            });
                        });
                    
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(140)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(сумма прописью)")
                            .Italic()
                            .FontSize(6)
                            .Light();
                    });
            });

        page.Footer()
            .Height(1, Unit.Centimetre)
            .AlignRight()
            .PaddingRight(10)
            .AlignMiddle()
            .Text(text =>
            {
                text.DefaultTextStyle(x=>x.FontSize(6));
                text.Span("Страница: ");
                text.CurrentPageNumber().FontSize(6);
                text.Span(" из ");
                text.TotalPages().FontSize(6);
            });
    });
}).ShowInPreviewer();*/

#endregion

#region full packige

/*
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
                    .PaddingTop(10)
                    .Text(text =>
                    {
                        text.DefaultTextStyle(x => x.Light()
                            .FontSize(10)
                            .FontColor(Colors.Black));
                        text.Span("ОТКРЫТОЕ АКЦИОНЕРНОЕ ОБЩЕСТВО «БЕЛОРУССКАЯ УНИВЕРСАЛЬНАЯ ТОВАРНАЯ БИРЖА»");
                    });
            });

        page.Content()
            .PaddingTop(10)
            .Grid(grid =>
            {
                grid.AlignCenter();
                grid.Columns(10); // 12 by default

                grid.Item(10)
                    .PaddingLeft(10)
                    .Text("Получатель: ОАО «Белорусская универсальная товарная биржа», УНП 190542056\nСчет №: BY23AKBB30120000059140000000, банк получателя: ОАО «АСБ Беларусбанк», пр. Дзержинского, 18, БИК AKBBBY2X");

                grid.Item(10).PaddingTop(20).PaddingBottom(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        //columns.RelativeColumn();
                        //columns.RelativeColumn();
                      
                        //table.Cell().PaddingLeft(10).Text("Секция 03");
                        table.
                            Cell()
                            .AlignCenter()
                            .Text("РЕЕСТР СДЕЛОК УЧАСТНИКА БИРЖЕВОЙ ТОРГОВЛИ")
                            .FontSize(16)
                            .SemiBold();
                        //table.Cell().AlignRight().PaddingRight(10).Text("116768");
                    });
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(400)
                    .Text("ООО \"АВАБИ\". Адрес РЕСПУБЛИКА БЕЛАРУСЬ, 220005, г. Минск, ул. Платонова дом 20Б корпус 3 квартира/офис 148. УНП (ЕГРН) 100172248. Договор на биржевое обслуживание биржевого брокера №454 от 10.12.2021, Договор на биржевое обслуживание посетителя торгов №401 от 01.09.2021");

                grid.Item(8)
                    .AlignCenter()
                    .Text("(полное наименование участника биржевой торговли, его местонахождение, УНП, № и дата договора на биржевое обслуживание)")
                    .Italic()
                    .FontSize(6);
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(400)
                    .Text("000138210")
                    .Underline();
                
                grid.Item(8)
                    .AlignCenter()
                    .Text("(краткое наименование обособленного подразделения и его местонахождение, УНП, регистрационный номер)")
                    .Italic()
                    .FontSize(6);
                
                grid.Item(10)
                    .AlignLeft()
                    .PaddingTop(20)
                    .PaddingBottom(5)
                    .Border(1)
                    .BorderColor(Colors.Grey.Lighten1)
                    .AlignLeft()
                    .Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(175);
                            columns.ConstantColumn(86);  
                            columns.ConstantColumn(75);  
                            columns.ConstantColumn(75);
                            
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("Сельхозпродукция");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("Торговая сессия");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("19.09.2022");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).ExtendHorizontal().AlignLeft().AlignCenter().Text("Продажа");
                        });
                    });
                
                grid.Item(10).PaddingBottom(20).Table(table =>
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
                        IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                      
                        table.Cell().ColumnSpan(4).Element(CellStyleForHeader).AlignCenter().Text("Плата за организацию и проведение биржевых торгов\n (биржевой сбор)");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Ставка биржевого сбора, %");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора без НДС");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма НДС");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора с НДС");
                        
                        IContainer CellStyleForTable(IContainer container) => DefaultCellStyle(container, Colors.White).ShowOnce();
                        
                    });
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
                        
                        table.Cell().Element(CellStyleForHeader).Text("1").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("2").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("3").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("4").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("5").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("6").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("7").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("8").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("9").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("10").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("11").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("12").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("13").NormalWeight();
                        table.Cell().Element(CellStyleForHeader).Text("14").NormalWeight();
                      
                        IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                        
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("Итог").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("RUB").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("1385.33").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("X").NormalWeight();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        table.Cell().Element(CellStyleForTable).ShowEntire().Text("0,11 BYN").ExtraBold();
                        
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
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .Text("Итого участником биржевых торгов совершено 2 ( две ) сделки на сумму")
                    .Light();
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .Text("1 358,50 ( одна тысяча триста пятьдесят восемь ) российских рублей 50 копеек");
                
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(10)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(Сумма прописью)")
                            .Italic()
                            .FontSize(6);
                    });
                    
                    grid.Item(10)
                        .PaddingTop(10)
                        .PaddingLeft(10)
                        .Text("Всего сумма к оплате за услуги по организации и проведению биржевых торгов (биржевой сбор) составляет")
                        .Light();
                
                    grid.Item(10)
                        .PaddingLeft(10)
                        .Text("0,13 BYN ( ноль ) белорусских рублей 13 копеек");
                    
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(10)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(Сумма прописью)")
                            .Italic()
                            .FontSize(6);
                    });
                    
                    grid.Item(10)
                        .AlignLeft()
                        .PaddingLeft(10)
                        .PaddingTop(10)
                        .AlignLeft()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(95);
                                columns.ConstantColumn(25);
                                columns.RelativeColumn();
                            
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("В том числе НДС по ставке")
                                    .Light();
                                
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("200%");
                                
                                table.Cell()
                                    .ExtendHorizontal()
                                    .AlignLeft()
                                    .Text("0,02 BYN ( ноль ) белорусских рублей 02 копейки");
                            });
                        });
                    
                    grid.Item(10).Column(column =>
                    {
                        column.Item()
                            .PaddingLeft(10)
                            .PaddingRight(10)
                            .LineHorizontal(1)
                            .LineColor(Colors.Black);
                        
                        column.Item()
                            .AlignCenter()
                            .Text("(Сумма прописью)")
                            .Italic()
                            .FontSize(6);
                    });
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
*/

#endregion

#region withTable

/*
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
            .PaddingTop(10)
            .Grid(grid =>
            {
                grid.AlignCenter();
                grid.Columns(10); // 12 by default

                grid.Item(10)
                    .PaddingLeft(10)
                    .Text("Получатель: ОАО «Белорусская универсальная товарная биржа», УНП 190542056\nСчет №: BY23AKBB30120000059140000000, банк получателя: ОАО «АСБ Беларусбанк», пр. Дзержинского, 18, БИК AKBBBY2X");

                grid.Item(10).PaddingTop(20).PaddingBottom(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                      
                        table.Cell().PaddingLeft(10).Text("Секция 03");
                        table.Cell().AlignCenter().Text("РЕЕСТР СДЕЛОК УЧАСТНИКА БИРЖЕВОЙ ТОРГОВЛИ");
                        table.Cell().AlignRight().PaddingRight(10).Text("116768");
                    });
                });
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(400)
                    .Text("ООО \"АВАБИ\". Адрес РЕСПУБЛИКА БЕЛАРУСЬ, 220005, г. Минск, ул. Платонова дом 20Б корпус 3 квартира/офис 148. УНП (ЕГРН) 100172248. Договор на биржевое обслуживание биржевого брокера №454 от 10.12.2021, Договор на биржевое обслуживание посетителя торгов №401 от 01.09.2021")
                    .Underline();

                grid.Item(8)
                    .AlignCenter()
                    .Text("(полное наименование участника биржевой торговли, его местонахождение, УНП, № и дата договора на биржевое обслуживание)")
                    .Italic()
                    .FontSize(6);
                
                grid.Item(10)
                    .PaddingLeft(10)
                    .PaddingRight(400)
                    .Text("000138210")
                    .Underline();
                
                grid.Item(8)
                    .AlignCenter()
                    .Text("(краткое наименование обособленного подразделения и его местонахождение, УНП, регистрационный номер)")
                    .Italic()
                    .FontSize(6);
                
                grid.Item(10)
                    .AlignLeft()
                    .PaddingTop(20)
                    .PaddingBottom(5)
                    .Border(1)
                    .BorderColor(Colors.Grey.Lighten1)
                    .AlignLeft()
                    .Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(175);
                            columns.ConstantColumn(86);  
                            columns.ConstantColumn(75);  
                            columns.ConstantColumn(75);
                            
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("Сельхозпродукция");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("Торговая сессия");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).AlignLeft().AlignCenter().Text("19.09.2022");
                            table.Cell().ExtendHorizontal().Border(1).BorderColor(Colors.Grey.Lighten1).ExtendHorizontal().AlignLeft().AlignCenter().Text("Продажа");
                        });
                    });
                
                grid.Item(10).PaddingBottom(20).Table(table =>
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
                        IContainer CellStyleForHeader(IContainer container) => DefaultCellStyle(container, Colors.Grey.Lighten3);
                      
                        table.Cell().ColumnSpan(4).Element(CellStyleForHeader).AlignCenter().Text("Плата за организацию и проведение биржевых торгов\n (биржевой сбор)");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Ставка биржевого сбора, %");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора без НДС");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма НДС");
                        table.Cell().Element(CellStyleForHeader).AlignCenter().Text("Сумма биржевого сбора с НДС");
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
                });
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

*/

#endregion