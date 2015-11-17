using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

/*

    meerdere lijnen commentaar
*/

    //1 lijnt comentaar


namespace Hybrid_SaaS
{
    public enum Link
    {
        //Menu opties
        MenuHome,
        MenuPakketten,
        MenuModules,
        MenuOver,
        MenuSupport,
        MenuContact,


        
        Abonnementen,
        Administratie,
        AlgemeneVoorwaarden,
        AlgemeneVoorwaardenPdf,
        Alles,
        BalansWinstVerliesrekening,
        Bankrekening,
        Bedrijfsagenda,
        BrowserDownload,
        Certificatenbeheer,
        Commisie,
        Commissiebeheer,
        Contractenbeheer,
        Crm,
        Dataopslag,
        Download,
        Email,
        ExportBoekhouding,
        ExportExcel,
        ExportExternPakket,
        Extranet,
        Facebook,
        Factsheet,
        Facturatie,
        FacturatieDebiteurbeheer,
        Financieel,
        Gebouwbeheer,
        GebruikerExtern,
        GebruikerIntern,
        GooglePlus,
        Handleiding,
        HelpDesk,
        Hrm,
        InkoopfacturatieCrediteurenbeheer,
        Inkooporderbeheer,
        Inventarisbeheer,
        InvoerTicket,
        KijkMetMijMee,
        KmRegistratie,
        LicentieVoorwaardenPdf,
        Meerwerk,
        MeestGesteldeVragen,
        Notities,
        OffertesOrders,
        OutlookAddDownload,
        OutlookAddIn,
        Overig,
        PakketAanvullendFinancieel,
        PakketContractbeheer,
        PakketErp,
        PakketKwaliteitsControle,
        PakketKwaliteitsControleTickets,
        PakketOfferteVoorraad,
        PakketTicketsFacturatie,
        Prepaidkaarten,
        Productenbeheer,
        Prognosebeheer,
        Projectbeheer,
        Relatiebeheer,
        ReleaseNotes,
        SiteMap,
        Termijnstatenbeheer,
        TicketSysteem,
        Tijdregistratie,
        Twitter,
        Voorraadbeheer,
        VragenlijstenEquettes,
        Wachtwoordbeheer,
        Webshop,
        Werkbonnen,
        WordAddDownload,
        Youtube,
        prijzenlijst,
        pakketCommisiebeheer,
        Consultancy,
        Correspondentie,
        Onderaannemer,
        Voortgang,


    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Name;
            public string Url = "#";
            public string Title = "";
            public string Description = "";
            public string Images = "";
            public string Price = "";
            public string LinkName = "";
            public string BigImages = "";

            //indien pagetitle leeg is, valt deze terug naar title
            public string PageTitle;

            public bool OpenInNewWindow
            {
                get;
                set;
            }
        }

        public static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();
        public static Dictionary<string, LinkInfo> UrlDictionary = new Dictionary<string, LinkInfo>(StringComparer.InvariantCultureIgnoreCase);

        public static string GetLink(Link link)
        {
            return LinkDictionary[link].Url;
        }
        public static string GetTitle(Link link)
        {
            return LinkDictionary[link].Title;
        }
        public static string GetDescription(Link link)
        {
            return LinkDictionary[link].Description;
        }
        public static string GetImages(Link link)
        {
            return LinkDictionary[link].Images;
        }
        public static string GetPrice(Link link)
        {
            return LinkDictionary[link].Price;
        }
        public static string GetLinkName(Link link)
        {
            return LinkDictionary[link].LinkName;
        }
        public static string GetBigImages(Link link)
        {
            return LinkDictionary[link].BigImages;
        }
        


        static LinkList()
        {

            //modules

            LinkDictionary[Link.MenuModules] = new LinkInfo
            {
                Name = "Modules",
                Url = "/modules",

                Title = "Ga naar de module-overzichts pagina",
                PageTitle = "Module overzicht",
                Price = "Vanaf € 30,- per maand",
                LinkName = "Modules",
                Images = "/images/why_arrow.png",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Abonnementen] = new LinkInfo
            {
                Url = "/Module/Abonnementen",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Description = "De module Hybrid SaaS Abonnementenbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige abonnementen. Met Hybrid SaaS Abonnementenbeheer loop je nooit meer achter de feiten aan.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Abonnementen",
                BigImages = "/images/advantage_img7.png",
            };
            
            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Url = "/Module/bankrekening",
                Title = "De module Bankrekeningen schept orde in de chaos. U kan eenvoudig banktransacties importeren en afletteren waardoor u altijd inzicht heeft in de openstaande en betaalde facturen.",
                Description = "Lees de banktransacties in en koppel ze eenvoudig aan openstaande verkoopfacturen. Het is ook mogelijk om incassobatches aan te maken. Het inlezen van banktransacties is ook handig voor de verwerking van inkoopfacturen. Zo kun je afschrijvingen direct koppelen aan de grootboekrekening of gegevens van inkoopfacturen automatisch gebruiken voor betalingen en incasso's.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Bankrekening",
                BigImages = "/images/advantage_img7.png",

            };

            LinkDictionary[Link.BalansWinstVerliesrekening] = new LinkInfo
            {
                Url = "/Module/balans-winst-verliesrekening",
                Title = "De balans & winsten verliesrekening is een kasstroomoverzicht en daarmee een onderdeel van een jaarrekening. De balans & winst en verliesrekening geeft een overzicht van de kosten en opbrengsten van de entiteit over een bepaalde periode (meestal een jaar). ",
                Description = "Het saldo van de balans & winst en verliesrekening is de over de periode behaalde winst of het over de periode geleden verlies. In dit artikel wordt het proces om een balans & winst en verliesrekening op te maken beschreven. Voordat u een Balans & Winst en verliesrekening kunt opmaken dient u eerst de basis inrichting uit te voeren",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Balans Winst & Verliesrekening",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Url = "/Module/bedrijfsagenda",
                Title = "Met de bedrijfsagenda kan je heel eenvoudig het rooster van je mederwerkers bijhouden, je kan in één opslag zien hoeveel uur een mederwerker nog heeft staan of al heeft opgenomen. ",
                Description = "Vanuit de bedrijfagenda kan je makkelijk een ticket aanmaken en inplannen, een verlof aanvragen of een bedrijfsgebeurtenis aanmaken. Je kan per mederwerker ook een export naar excel maken zodat je makkelijk kunt zien wanneer er vrij is genomen of ziek is geweest.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Bedrijfsagenda",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Url = "/Module/certificatenbeheer",
                Title = "Eenvoudig kunnen zien wanneer een het rijbewijs of paspoort verloopt van je persooneel verloopt? Hybrid SaaS maakt het mogelijk! ",
                Description = "De module Certificatenbeheer schept orde in de chaos en plaatst alle certificaten overzichtelijk bij elkaar.Wanneer een certificaat tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Zodat je gegevens altijd op orde zijn.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Certificatenbeheer",
                BigImages = "/images/advantage_img7.png",

            };

            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Url = "/Module/commissciebeheer",
                Title = "Werk je met resellers? Dan is Commissiebeheer van Hybrid SaaS zeker interessant voor jouw organisatie. ",
                Description = "Met Commissiebeheer zorg je ervoor dat de registraties en betalingen van provisies altijd op orde zijn. Voor iedere factuur die jij verstuurt rekenen wij uit hoeveel commissie je af dient te dragen aan wederverkopers, resellers of agenten. Of je nu werkt met Tickets & Facturatie, Contractbeheer of Offerte & Voorraad, Commissiebeheer sluit naadloos aan bij al deze pakketten.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Commissiebeheer",
                BigImages = "/images/advantage_img7.png",

            };
            
            LinkDictionary[Link.Contractenbeheer] = new LinkInfo
            {
                Url = "/Module/contractenbeheer",
                Title = "Waarom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? Met Hybrid SaaS Contracten heb je nauwelijks omkijken naar je periodiek uitgaande facturen en bestellingen en zo verbeter je eenvoudig je positieve cashflow.",
                Description = "Periodiek terugkerende bestellingen plaats je automatisch bij je leveranciers. Abonnementen van je klanten kunnen worden ingegeven, waarbij de factuur per ingegeven termijn wordt verstuurd. Verzend facturen en bestellingen direct via e-mail. Bestaande orders en facturen kunnen direct geautomatiseerd worden.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Contractenbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Crm] = new LinkInfo
            {
                Url = "/Module/Crm",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Crm",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Correspondentie] = new LinkInfo
            {
                Url = "/Module/Correspondentie",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Correspondentie",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.FacturatieDebiteurbeheer] = new LinkInfo
            {
                Url = "/Module/debiteurbeheer",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk! ",
                Description = "De module Hybrid SaaS facturatie-debiteurbeheerbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige facturatie-debiteurbeheer. Met Hybrid SaaS facturatie-debiteurbeheerbeheer loop je nooit meer achter de feiten aan.",
                Images = "images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Debiteurbeheer",
                BigImages = "images/advantage_img7.png",

            };
            LinkDictionary[Link.Extranet] = new LinkInfo
            { 
                Url = "/Module/Extranet",
                Description = "De module Hybrid SaaS Extranetbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige Extranet. Met Hybrid SaaS Extranetbeheer loop je nooit meer achter de feiten aan.",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid SaaS maakt het mogelijk!",
                Images = "/images/modules_img5.png",
                Price = "€ 30,- per maand",
                LinkName = "Extranet",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            { 
                Url = "/Module/exportboekhouding",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per extern boekhoudpakket",
                LinkName = "Export externe boekhouding",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Url = "/Module/facturatie",
                Title = "Een goede cashflow begint bij het op tijd versturen van je facturen. Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen.",
                Description = "Je maakt gebruik van vooraf ingestelde gegevens. Op deze manier win je veel tijd en wordt de kans op fouten aanzienlijk verkleind. Facturen worden overzichtelijk opgeslagen en zijn hierdoor eenvoudig terug te vinden. Het verzenden van kopie- en creditfacturen was nog nooit zo gemakkelijk. Daarnaast geeft de module altijd het actuele facturatieproces weer en kun je in één oogopslag zien welke facturen zijn afgehandeld en welke er nog openstaan. Wanneer een betalingstermijn van een factuur is verstreken kunnen er gemakkelijk en snel betalingsherinneringen worden verstuurd.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Facturatie",
                BigImages = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Url = "/Financieel",
                Title = "Wil je het boekhoudproces nog slimmer inrichten? Kies dan ons pakket Financieel. Dit is de perfecte aanvulling op bijvoorbeeld Tickets & Facturatie of Offerte & Voorraad.",
                Description = "Wij hebben zelf een boekhoudpakket ontwikkeld waarmee je eenvoudig digitaal online de complete boekhouding bijhoudt. Van het versturen van facturen tot een actueel overzicht in de balans, winst- en verliesrekening; dit pakket is zo ontworpen dat het voor 100% aansluit op de andere pakketten van Hybrid SaaS.",
                Images = "/images/why_arrow.png",
                Price = "€ 125,- per maand",
                LinkName = "Financieel",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            { 
                Url = "/Module/Gebouwbeheer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Gebouwbeheer",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Hrm] = new LinkInfo
            {
                Url = "/Module/human-resource-management",
                Title = "Met Hybrid SaaS Human Resource Management kun je personeelszaken eenvoudig automatiseren en heb je altijd een up-to-date inzicht in de gehele personeelsadministratie. ",
                Description = "Alle personeelsgegevens staan op één centrale veilige plaats en zaken als contactgegevens, dienstverband en verlofuren kunnen altijd en overal worden geraadpleegd. Het zogenoemde Employee Self Service (ESS) maakt het mogelijk dat medewerkers zelf veranderingen en aanvragen in kunnen dienen. Deze worden vervolgens door de betreffende manager goedgekeurd en definitief doorgevoerd.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Human Resource Management (HRM)",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Inventarisbeheer] = new LinkInfo
            {
                Url = "/Module/inventarisbeheer",
                Title = "Uw heeft diverse objecten in uw bezit, maar geen idee waar deze zich bevinden. Laat staan dat u snel handleidingen, inkoopfacturen of serienummers kunt opzoeken. ",
                Description = "Met Online Inventarisbeheer van Hybrid SaaS kunnen gegevens over uw inventaris overzichtelijk worden geregistreerd en gecontroleerd. Bij elk object kunt u aankooprijs, identificatienummers en diverse data vastleggen.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Inventarisbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.KmRegistratie] = new LinkInfo
            {
                Url = "/Module/km-registratie",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                BigImages = "/images/advantage_img7.png",
                LinkName = "Km -Registratie",


            };
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Url = "/Module/Notities",
                Title = "Met de Module Notities kan je eenvoudig een verslag bijhouden wat er is afgesproken met de klant. Je kan hem inplannen zodat hij een dag van te voren als je een afspraak heb staan weer naar voren komt.",
                Description = "Ook kan je er bijlage in bijhouden. Dus alle relevante informatie over het gesprek word bij elkaar bewaard zodat je het altijd terug kan vinden",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Notities",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.OffertesOrders] = new LinkInfo
            {
                Url = "/Module/offertes-orders",
                Title = "In een handomdraai een professionele offerte opstellen en daarna vliegensvlug omzetten in een order? Dat kan! Met de module Hybrid SaaS Offertes & Orders. Eenmalig stel je een offerte lay-out op, waarna je alleen nog maar de producten of diensten als offerteregels hoeft toe te voegen. ",
                Description = "Deze basis kan na acceptatie van de offerte dienen als order, werkbon en/of pakbon, waarbij alleen de lay-out verandert. De offerte dan wel order kan rechtstreeks digitaal verzonden worden vanuit Hybrid SaaS.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Offertes & Orders",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Onderaannemer] = new LinkInfo
            {
                Url = "/Module/Onderaannemer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Onderaannemer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.OutlookAddIn] = new LinkInfo
            {
                Url = "/Module/Outlook-Add-in",
                Title = "Door middel van de Outlook add-in krijg je de mogelijkheid om e-mails vanuit Microsoft Outlook mailbox om te zetten in tickets. ",
                Description = "Op deze manier kan je je mailbox leeg houden en sla je e-mails netjes op bij de juiste relaties en/ of projecten.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Outlook Add-In",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Url = "/Module/Prepaidkaarten",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Prepaidkaarten",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Productenbeheer] = new LinkInfo
            {
                Url = "/Module/productenbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Productenbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Prognosebeheer] = new LinkInfo
            {
                Url = "/Module/prognosebeheer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Prognosebeheer",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Projectbeheer] = new LinkInfo
            {
                Url = "/Module/Projectbeheer",
                Title = "Met de module Projectbeheer worden alle projectgegevens op één centrale plaats vastgelegd. De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven.",
                Description = "Met Hybrid SaaS Projectbeheer ben je in staat om projecten eenvoudiger te managen. Ook kun je deadlines gemakkelijk monitoren, openstaande taken inzien en het vastgestelde budget bewaken. Per project kun je financiële afspraken vastleggen en altijd en overal de projecthistorie inzien. Offertes en facturen kunnen eenvoudig aan projecten worden gekoppeld en met één druk op de knop worden verstuurd. Kortom, een forse tijdbesparing!",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Projectbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Relatiebeheer] = new LinkInfo
            {
                Url = "/Module/relatiebeheer",
                Title = "Relaties zijn de motor van iedere organisatie. Juist daarom is het belangrijk om als organisatie over een compleet en overzichtelijk CRM-systeem (Customer Relationship Management) te beschikken.",
                Description = ".Met de module Relatiebeheer van Hybrid SaaS kunnen klantgegevens gemakkelijk en snel worden vastgelegd. Bovendien heeft elke medewerker altijd en overal toegang tot de actuele gegevens en de historie van elke klant. Dit is ook voor de klant een goede zaak, want dit zorgt voor een optimale klantbediening.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Relatiebeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Url = "/Module/ticket-systeem",
                Title = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen. Weet precies wat er speelt bij je relaties, projecten en je eigen organisatie. Met behulp van de juiste categorieën en urgentie bepaal je zelf waar de prioriteiten liggen en heb je altijd een actueel overzicht. ",
                Description = "Op deze manier krijg je een beter inzicht in openstaande acties en verhoog je de efficiëntie en servicegerichtheid naar je (klant) relaties. Communicatie is misschien wel het belangrijkste element voor een goede samenwerking. Ons doel is bedrijven en hun relaties dichter bij elkaar te brengen om op deze manier een optimale samenwerking te realiseren. Klantvragen komen via verschillende kanalen binnen en worden vaak op verschillende plaatsen opgeslagen. Door de inefficiënte gaat veel tijd verloren en gooi je onnodig geld weg. Het ticketsysteem van Hybrid SaaS biedt veel mogelijkheden om dit te voorkomen en is vrijwel door ieder bedrijf te gebruiken.",
                Images = "/images/why_arrow.png",
                Price = "€ 40,- per maand",
                LinkName = "Ticketsysteem",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Tijdregistratie] = new LinkInfo
            {
                Url = "/Module/tijdregistratie",
                Title = "Het bijhouden van gewerkte uren wordt door medewerkers vaak als een tijdrovende klus beschouwd. Mede hierdoor wordt deze taak nogal eens uitgesteld en worden er achteraf dikwijls foutieve gegevens vastgelegd. ",
                Description = "Maar daar komt vanaf nu verandering in. Met Hybrid SaaS Tijdregistratie kan iedere medewerker op elke gewenst moment snel en eenvoudig uren, onkosten en kilometers registreren. Op deze manier creëer je meer uniformiteit, tijden worden accurater bijgehouden en je beschikt altijd en overal over de meest actuele gegevens.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Tijdregistratie",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Voorraadbeheer] = new LinkInfo
            {
                Url = "/Module/voorraadbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid SaaS Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = "Ook is het mogelijk om producten naar eigen inzicht onder te verdelen aan de hand van verschillende eigenschappen, zoals productkenmerken, product- of barcodes en leveranciers. Hybrid SaaS Productbeheer helpt je een goed overzicht te houden over je producten en maakt het gemakkelijk om gegevens aan te passen of een productafbeelding toe te voegen. Wanneer een product niet meer op voorraad is, word je hier automatisch van op de hoogte gesteld. Wel zo gemakkelijk!",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Voorraadbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Voortgang] = new LinkInfo
            {
                Url = "/Module/voortgang",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Voortgang",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.VragenlijstenEquettes] = new LinkInfo
            {
                Url = "/Module/vragenlijsten",
                Title = "Informatie is misschien wel het belangrijkste onderdeel binnen elke organisatie. Maar hoe zorgt u ervoor dat u de juiste informatie krijgt, zonder dat er een hele papierstroom aan vooraf gaat.",
                Description = " Met de Online Enquête en vragenlijsten van Hybrid SaaS kunt u klanttevredenheidsonderzoeken uitvoeren, gestandaardiseerde (voor) opnamelijsten en nog veel meer. U heeft de volledige vrijheid om zelf vragen op te stellen en deze te laten beantwoorden door middel van muliplechoice of open antwoorden.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Vragenlijst & Equettes",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Wachtwoordbeheer] = new LinkInfo
            {
                Url = "/Module/wachtwoordbeheer",
                Title = "Je heb zoveel verschillende website's en zoveel verschillende inloggegevens dat je het overzicht zo kwijt ben welk wachtwoord waarbij hoort. ",
                Description = "In deze module kunt u wachtwoorden registreren en koppelen aan het bedrijf zodat u altijd uw wachtwoorden bij de hand heeft.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Wachtwoordbeheer",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Url = "/Module/webshop",
                Title = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden.",
                Description = "Met een webshop ben je niet locatie gebonden en 24 uur per dag, 7 dagen per week bereikbaar. De uitgelezen kans om nieuwe klanten aan te trekken en de behoeften van bestaande klanten te voorzien. Online winkelen, het nieuwe winkelen!",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per site",
                LinkName = "Webshop",
                BigImages = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.Werkbonnen] = new LinkInfo
            {
                Url = "/Module/werkbonnen",
                Title = "Buitendienstmedewerkers zijn veel tijd kwijt aan het invullen van papieren werkbonnen. Waarom zou u onnodig papier en tijd verspillen, terwijl uw werkbonnen gedigitaliseerd kunnen worden. ",
                Description = " Met de digitale werkbon kunnen uw buitendienstmedewerkers snel een eenvoudig werkzaamheden en kosten registreren. Het overtypen van handgeschreven werkbonnen behoort tot het verleden. De communicatietijd zal verkleinen terwijl u de efficiëntie verhoogd. Doordat de werkbonnen direct gekoppeld zijn aan uw backoffice heeft u altijd en over een actueel overzicht.",
                Images = "/images/why_arrow.png",
                Price = "€ 30,- per maand",
                LinkName = "Werkbonnen",
                BigImages = "/images/advantage_img7.png",

            };
            LinkDictionary[Link.GebruikerIntern] = new LinkInfo
            {
                Url = "/Module/Gebruiker-intern",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 5,- per gebruiker",
                LinkName = "Gebruikers",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.GebruikerExtern] = new LinkInfo
            {
                Url = "/Module/Gebruiker-extern",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 10,- per 10 medewerkers",
                LinkName = "Buitendienst medewerkers",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            {
                Url = "/Module/Dataopslag",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 10,- per 10 GB",
                LinkName = "10 GB dataopslag",
                BigImages = "/images/advantage_img7.png",


            };

            
            //modulles hebben nog geen pagina


            LinkDictionary[Link.InkoopfacturatieCrediteurenbeheer] = new LinkInfo
            {
                Url = "/inkoopfacturatie-en-crediteurenbeheer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "InkoopfacturatieCrediteurenbeheer",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Inkooporderbeheer] = new LinkInfo
            {
                Url = "/Module/Inkooporderbeheer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Inkooporderbeheer",
                BigImages = "/images/advantage_img7.png",


            };
             
            LinkDictionary[Link.ExportExcel] = new LinkInfo
            { 
                Url = "/Module/Excel-export",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Export naar Excel",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Email] = new LinkInfo
            { 
                Url = "#",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "E-mail",
                BigImages = "/images/advantage_img7.png",


            };
           
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            { 
                Url = "/Module/Externpakket",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Export extern pakket",
                BigImages = "/images/advantage_img7.png",


            };
            
            LinkDictionary[Link.Termijnstatenbeheer] = new LinkInfo
            {
                Url = "/Module/Termijnstatenbeheer",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Termijnstatenbeheer",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Meerwerk] = new LinkInfo
            {
                Url = "/Module/Meerwerk",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Meerwerk",
                BigImages = "/images/advantage_img7.png",
            };





            //pakketten


            LinkDictionary[Link.MenuPakketten] = new LinkInfo
            {
                Name = "Pakketten",
                Url = "/pakketten",

                Title = "Ga naar de pakketten-overzichts pagina",
                PageTitle = "Pakketten overzicht",
                BigImages = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 300,- per maand",
                LinkName = "Pakket Offerte & Voorraad",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketErp] = new LinkInfo
            {
                Url = "/pakket-erp",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 500,- per maand",
                LinkName = "Pakket Erp",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketKwaliteitsControleTickets] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle-tickets",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "€ 250,- per maand",
                LinkName = "Pakket KwaliteitsControle & Tickets",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketKwaliteitsControle] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle",
                Title = "",
                Description = "",
                Images = "/images/ticket_icon3a.png",
                Price = "€ 100,- per maand",
                LinkName = "Pakket Kwaliteitscontrole",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie",
                Title = "",
                Description = "",
                Images = "/images/ticket_icon2a.png",
                Price = "€ 250,- per maand",
                LinkName = "Pakket Tickets & Facturatie",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.PakketContractbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer",
                Title = "",
                Description = "",
                Images = "/images/ticket_icon1.png",
                Price = "€ 125,- per maand",
                LinkName = "Pakket Contractbeheer",
                BigImages = "/images/advantage_img7.png",


            };

            //support

            LinkDictionary[Link.WordAddDownload] = new LinkInfo
            { 
                Url = "https://download.hybridsaas.com/install/word/setup.exe",
                Title = "Hybrid SaaS Word add-in",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS word add-in",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS browser",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { 
                Url = "http://download.hybridsaas.com/install/office/outlook/",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Hybrid SaaS outlook add-in",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.KijkMetMijMee] = new LinkInfo
            { 
                Url = "http://www.kijkmetmijmee.nl/Hybrid%20SaaS%20-%20Customer%20Support.exe",
                Title = "",
                Description = "Wij kunnen op afstand meekijken op uw computer, gebruik deze optie om onze medewerkers toegang te geven tot uw pc.",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Kijk met mij mee",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.InvoerTicket] = new LinkInfo
            {
                Url = "https://hybridsaas.hybridsaas.com/Extranet-revisited/Ticket/Ticket.create.asp",
                Title = "",
                Description = "Stel snel en gemakkelijk uw vraag online aan onze organisatie.",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Ticketsysteem",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.HelpDesk] = new LinkInfo
            {
                Url = "#",
                Title = "",
                Description = "Onze contact gegevens.",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Helpdesk",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Handleiding] = new LinkInfo
            {
                Url = "http://hybridsaas.support/pages",
                Title = "",
                Description = "Onze uitgebreide handleiding geeft inzicht in de werking van onze software.",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Handleiding",
                BigImages = "/images/handleidinghs.png",


            };
            LinkDictionary[Link.Download] = new LinkInfo
            {
                Url = "",
                Title = "Downloads",
                Description = "Downloads",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Downloads",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Consultancy] = new LinkInfo
            {
                Url = "",
                Title = "Consultancy",
                Description = "Maak gebruik van onze jarenlange kennis als systeembeheerder, softwareontwikkelaar & bedrijfsautomatiseerder.",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Consultancy",
                BigImages = "/images/advantage_img7.png",


            };


            //overige

            LinkDictionary[Link.LicentieVoorwaardenPdf] = new LinkInfo
            { 
                Url = "http://www.hybridsaas.com/images/Algemene%20licentievoorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "LicentieVoorwaardenPdf",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.AlgemeneVoorwaardenPdf] = new LinkInfo
            { 
                Url = "http://www.hybridsaas.com/images/Algemene%20voorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "AlgemeneVoorwaardenPdf",
                BigImages = "/images/advantage_img7.png",


            };
            
            LinkDictionary[Link.prijzenlijst] = new LinkInfo
            {
                Url = "#",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "prijzenlijst",
                BigImages = "/images/advantage_img7.png",
            };

            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "/Meest-gestelde-vragen",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Meest Gestelde Vragen",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.MenuContact] = new LinkInfo
            {
                Name = "Contact",
                Url = "/contact",
                Title = "Ga naar de contactpagina",
                PageTitle = "Contactgegevens"
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet",
                Title = "",
                Description = "",
                Images = "images/why_arrow.png",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.MenuHome] = new LinkInfo
            {
                Name = "Home",
                Url = "/",

                Title = "Ga naar de startpagina",
                PageTitle = "Welkom bij Hybrid SaaS",
                BigImages = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Name = "Release notes",
                Url = "http://hybridsaas.support/pages/release-notes/latest/release-notes",
                Title = "Ga naar de laatste release notes",
                OpenInNewWindow = true
            };
            LinkDictionary[Link.MenuSupport] = new LinkInfo
            {
                Name = "Support",
                Url = "/support",
                Title = "Ga naar de support pagina",

                PageTitle = "Supportpagina",
                BigImages = "/images/advantage_img7.png",
            };


            LinkDictionary[Link.MenuOver] = new LinkInfo
            {
                Name = "Over",
                Url = "/over",

                Title = "Over ons",
                BigImages = "/images/advantage_img7.png",
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie",
                Name = "YouTube",
                OpenInNewWindow = true,
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map",
                Name = "Sitemap",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.AlgemeneVoorwaarden] = new LinkInfo
            {
                Url = "/algemene-voorwaarden",
                Name = "Algemene voorwaarden"

            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Administratie] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Administratie",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Alles] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Alles",
                BigImages = "/images/advantage_img7.png",


            };
            LinkDictionary[Link.Overig] = new LinkInfo
            {//not init
                Url = "#",
                Title = "",
                Description = "",
                Images = "/images/why_arrow.png",
                Price = "",
                LinkName = "Overige",
                BigImages = "/images/advantage_img7.png",


            };
            

            /*var file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\robots.txt";
            string content = "";
            foreach (var item in LinkDictionary.Values)
            {
                content += "Allow: "+item.Url + Environment.NewLine;
            }
            File.WriteAllText(file,content);*/
        }
    }
}