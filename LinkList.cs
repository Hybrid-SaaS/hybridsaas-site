using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Hybrid_Saas
{
    public enum Link
    {
        Commisie,
        TicketSysteem,
        Contact,
        Factsheet, 
        Financieel,
        Index,
        Module,
        Molules,
        PakketContactbeheer,
        PakketOfferteVoorraad,
        PakketTicketsFacturatie,
        pakketAanvullendFinancieel,
        Pakketten,
        ReleaseNotes,
        Support,
        Webshop,
        Over,
        Blog,
        Youtube,
        Twitter,
        Facebook,
        SiteMap,
        AlgemeeneVoorwaarde,
        GooglePlus,
        lol,
		Abonnementen,
        Certificatenbeheer,
        Bankrekening,
        BalansWinstVerliesrekening,
        Bedrijfsagenda,
        Commissiebeheer,
        Contractenbeheer,
        FacturatieDebiteurbeheer,
        HRM,
        InkoopfacturatieCrediteurenbeheer,
        Inkooporderbeheer,
        Inventarisbeheer,
        KmRegistratie,
        Notities,
        OffertesOrders,
        Prepaidkaarten,
        Productenbeheer,
        Projectbeheer,
        Relatiebeheer,
        Tijdregistratie,
        Voorraadbeheer,
        VragenlijstenEquettes,
        Wachtwoordbeheer,
        Werkbonnen,
        Dataopslag,
        Administratie,
        Alles,
        Overig,
        GebruikerIntern,
        OutlookAddIn,
        Facturatie,
        CRM,
        ExportExcel,
        Email,
        Extranet,
        ExportExternPakket,
        ExportBoekhouding,    
        Download,
        HelpDesk,
        Handleiding,
        BrowserDownload,
        WordAddDownload,
        OutlookAddDownload,
        KijkMetMijMee,
        LicentievoorwaardenPDF,
        AlgemeeneVoorwaardePDF,
        InvoerTicket,
        Gebouwbeheer,
        MeestGesteldeVragen,
        GebruikerExtern,
        Prognosebeheer,
        Termijnstatenbeheer,
        Meerwerk,
        pakketerp,
        pakketkwaliteitscontrolletickets,
        pakketkwaliteitscontrolle,

    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Url = "#";
            public string Title = "";
            public string Description = "";
        }

        static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();


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

        static LinkList()
        {
            LinkDictionary[Link.pakketAanvullendFinancieel] = new LinkInfo
            {
                Url = "/pakket-aanvullend-financieel",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.MeestGesteldeVragen] = new LinkInfo
            {
                Url = "/Meest-gestelde-vragen",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Commisie] = new LinkInfo
            {
                Url = "/Commissie",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Contact] = new LinkInfo
            {
                Url = "/contact",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Url = "/Financieel",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Index] = new LinkInfo
            {
                Url = "/index",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Module] = new LinkInfo
            {
                Url = "/modules",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Molules] = new LinkInfo
            {
                Url = "/module",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.PakketContactbeheer] = new LinkInfo
            {
                Url = "/pakket-contractbeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.pakketerp] = new LinkInfo
            {
                Url = "/pakket-erp",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.pakketkwaliteitscontrolletickets] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle-tickets",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.pakketkwaliteitscontrolle] = new LinkInfo
            {
                Url = "/pakket-kwaliteitscontrolle",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Pakketten] = new LinkInfo
            {
                Url = "/pakketten",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Url = "http://hybridsaas.support/pages/release-notes/latest/release-notes",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Support] = new LinkInfo
            {
                Url = "/support",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Url = "/Module/ticket-systeem",
                Title = "Met het ticketsysteem krijg je de mogelijkheid om al je klantvragen te organiseren en op te volgen. Weet precies wat er speelt bij je relaties, projecten en je eigen organisatie. Met behulp van de juiste categorieën en urgentie bepaal je zelf waar de prioriteiten liggen en heb je altijd een actueel overzicht. ",
                Description = ""
            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Url = "/Module/webshop",
                Title = "Met de Hybrid SaaS Webwinkel kan snel en eenvoudig een webshop worden gerealiseerd en kun je direct producten en diensten aan(potentiele) klanten aanbieden.",
                Description = ""
            };
            LinkDictionary[Link.Over] = new LinkInfo
            {
                Url = "/over",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Blog] = new LinkInfo
            {
                Url = "/blog",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.AlgemeeneVoorwaarde] = new LinkInfo
            {
                Url = "/algemeene-voorwaarde",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Abonnementen] = new LinkInfo
            {
                Url = "/Module/Abonnementen",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid Saas maakt het mogelijk!",
                Description = "De module Hybrid Saas Abonnementenbeheer schept orde in de chaos en plaatst alle behaalde certificaten en afgesloten contracten overzichtelijk bij elkaar.Wanneer een certificaat of overeenkomst tegen de einddatum aanloopt word je hier automatisch van op de hoogte gesteld. Op deze manier voorkom je eenvoudig dat certificaten verlopen en je kosten moet betalen voor onnodige abonnementen. Met Hybrid Saas Abonnementenbeheer loop je nooit meer achter de feiten aan."
            };
            LinkDictionary[Link.Certificatenbeheer] = new LinkInfo
            {
                Url = "/Module/certificatenbeheer",
                Title = "Eenvoudig kunnen zien wanneer een het rijbewijs of paspoort verloopt van je persooneel verloopt? Hybrid Saas maakt het mogelijk! ",
                Description = ""
            };
            LinkDictionary[Link.Bankrekening] = new LinkInfo
            {
                Url = "/Module/bankrekening",
                Title = "De module Bankrekeningen schept orde in de chaos. U kan eenvoudig banktransacties importeren en afletteren waardoor u altijd inzicht heeft in de openstaande en betaalde facturen.",
                Description = ""
            };

            LinkDictionary[Link.BalansWinstVerliesrekening] = new LinkInfo
            {
                Url = "/Module/balans-winst-verliesrekening",
                Title = "De balans & winsten verliesrekening is een kasstroomoverzicht en daarmee een onderdeel van een jaarrekening. De balans & winst en verliesrekening geeft een overzicht van de kosten en opbrengsten van de entiteit over een bepaalde periode (meestal een jaar). ",
                Description = ""
            };
            LinkDictionary[Link.Bedrijfsagenda] = new LinkInfo
            {
                Url = "/Module/bedrijfsagenda",
                Title = "Met de bedrijfsagenda kan je heel eenvoudig het rooster van je mederwerkers bijhouden, je kan in één opslag zien hoeveel uur een mederwerker nog heeft staan of al heeft opgenomen. ",
                Description = ""
            };

            LinkDictionary[Link.Commissiebeheer] = new LinkInfo
            {
                Url = "/Module/commissciebeheer",
                Title = "Als bedrijf kan je externe bedrijven en/of personen inzetten om arbeid te verrichten. Deze diensten kan je belonen via commissie.",
                Description = ""
            };
            LinkDictionary[Link.Contractenbeheer] = new LinkInfo
            {
                Url = "/Module/contractenbeheer",
                Title = "Warom tijd blijven besteden aan steeds terugkerende facturen en bestellingen als het ook automatisch kan? Met Hybrid SaaS Contracten heb je nauwelijks omkijken naar je periodiek uitgaande facturen en bestellingen en zo verbeter je eenvoudig je positieve cashflow. ",
                Description = ""
            };
            LinkDictionary[Link.FacturatieDebiteurbeheer] = new LinkInfo
            {
                Url = "/Module/debiteurbeheer",
                Title = "Wil jij ook in één oogopslag kunnen zien wanneer een leasecontract afloopt en wanneer een telefoonabonnement of verzekering dient te worden verlengd? Hybrid Saas maakt het mogelijk! ",
                Description = ""
            };
            LinkDictionary[Link.HRM] = new LinkInfo
            {
                Url = "/Module/human-resource-management",
                Title = "Met Hybrid Saas Human Resource Management kun je personeelszaken eenvoudig automatiseren en heb je altijd een up-to-date inzicht in de gehele personeelsadministratie. ",
                Description = ""
            };
            LinkDictionary[Link.InkoopfacturatieCrediteurenbeheer] = new LinkInfo
            {
                Url = "/inkoopfacturatie-en-crediteurenbeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Inkooporderbeheer] = new LinkInfo
            {
                Url = "/Module/Inkooporderbeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Inventarisbeheer] = new LinkInfo
            {
                Url = "/Module/inventarisbeheer",
                Title = "Uw heeft diverse objecten in uw bezit, maar geen idee waar deze zich bevinden. Laat staan dat u snel handleidingen, inkoopfacturen of serienummers kunt opzoeken. ",
                Description = ""
            };
            LinkDictionary[Link.KmRegistratie] = new LinkInfo
            {
                Url = "/Module/km-registratie",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Notities] = new LinkInfo
            {
                Url = "/Module/Notities",
                Title = "Met de Module Notities kan je eenvoudig een verslag bijhouden wat er is afgesproken met de klant. Je kan hem inplannen zodat hij een dag van te voren als je een afspraak heb staan weer naar voren komt.",
                Description = ""
            };
            LinkDictionary[Link.OffertesOrders] = new LinkInfo
            {
                Url = "/Module/offertes-orders",
                Title = "In een handomdraai een professionele offerte opstellen en daarna vliegensvlug omzetten in een order? Dat kan! Met de module Hybrid Saas Offertes & Orders. Eenmalig stel je een offerte lay-out op, waarna je alleen nog maar de producten of diensten als offerteregels hoeft toe te voegen. ",
                Description = ""
            };
            LinkDictionary[Link.Prepaidkaarten] = new LinkInfo
            {
                Url = "/Module/Prepaid-kaarten",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Productenbeheer] = new LinkInfo
            {
                Url = "/Module/productenbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid Saas Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = ""
            };
            LinkDictionary[Link.Projectbeheer] = new LinkInfo
            {
                Url = "/Module/Projectbeheer",
                Title = "Met de module Projectbeheer worden alle projectgegevens op één centrale plaats vastgelegd. De projecten kunnen worden gekoppeld aan relaties en worden overzichtelijk en gestructureerd weergegeven.",
                Description = ""
            };
            LinkDictionary[Link.Relatiebeheer] = new LinkInfo
            {
                Url = "/Module/relatiebeheer",
                Title = "Relaties zijn de motor van iedere organisatie. Juist daarom is het belangrijk om als organisatie over een compleet en overzichtelijk CRM-systeem (Customer Relationship Management) te beschikken.",
                Description = ""
            };
            LinkDictionary[Link.Tijdregistratie] = new LinkInfo
            {
                Url = "/Module/tijdregistratie",
                Title = "Het bijhouden van gewerkte uren wordt door medewerkers vaak als een tijdrovende klus beschouwd. Mede hierdoor wordt deze taak nogal eens uitgesteld en worden er achteraf dikwijls foutieve gegevens vastgelegd. ",
                Description = ""
            };
            LinkDictionary[Link.Voorraadbeheer] = new LinkInfo
            {
                Url = "/Module/voorraadbeheer",
                Title = "Overal ter wereld je complete productenbestand snel en eenvoudig beheren? Hybrid Saas Productbeheer maakt het mogelijk. Producten worden voorzien van een duidelijke omschrijving en zijn op deze manier altijd gemakkelijk terug te vinden. ",
                Description = ""
            };
            LinkDictionary[Link.VragenlijstenEquettes] = new LinkInfo
            {
                Url = "/Module/vragenlijsten",
                Title = "Informatie is misschien wel het belangrijkste onderdeel binnen elke organisatie. Maar hoe zorgt u ervoor dat u de juiste informatie krijgt, zonder dat er een hele papierstroom aan vooraf gaat.",
                Description = ""
            };
            LinkDictionary[Link.Wachtwoordbeheer] = new LinkInfo
            {
                Url = "/Module/wachtwoordbeheer",
                Title = "Je heb zoveel verschillende website's en zoveel verschillende inloggegevens dat je het overzicht zo kwijt ben welk wachtwoord waarbij hoort. In deze module kunt u wachtwoorden registreren en koppelen aan het bedrijf zodat u altijd uw wachtwoorden bij de hand heeft.",
                Description = ""
            };
            LinkDictionary[Link.Werkbonnen] = new LinkInfo
            {
                Url = "/Module/werkbonnen",
                Title = "Buitendienstmedewerkers zijn veel tijd kwijt aan het invullen van papieren werkbonnen. Waarom zou u onnodig papier en tijd verspillen, terwijl uw werkbonnen gedigitaliseerd kunnen worden. ",
                Description = ""
            };
            LinkDictionary[Link.Dataopslag] = new LinkInfo
            { //not init
                Url = "/Module/Dataopslag",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Administratie] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Alles] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Overig] = new LinkInfo
            {//not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.GebruikerIntern] = new LinkInfo
            {//not init
                Url = "/Module/Gebruiker-intern",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.GebruikerExtern] = new LinkInfo
            {//not init
                Url = "/Module/Gebruiker-extern",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.OutlookAddIn] = new LinkInfo
            {//not init
                Url = "/Module/Outlook-Add-in",
                Title = "Door middel van de Outlook add-in krijg je de mogelijkheid om e-mails vanuit Microsoft Outlook mailbox om te zetten in tickets. Op deze manier kan je je mailbox leeg houden en sla je e-mails netjes op bij de juiste relaties en/ of projecten.",
                Description = ""
            };
            LinkDictionary[Link.Facturatie] = new LinkInfo
            {
                Url = "/Module/facturatie",
                Title = "Een goede cashflow begint bij het op tijd versturen van je facturen. Met Hybrid SaaS Facturatie kun je eenvoudig en snel een factuur opmaken en (digitaal) versturen. Je maakt gebruik van vooraf ingestelde gegevens. Op deze manier win je veel tijd en wordt de kans op fouten aanzienlijk verkleind. ",
                Description = ""
            };
            LinkDictionary[Link.CRM] = new LinkInfo
            { //not init
                Url = "/Module/commissciebeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.ExportExcel] = new LinkInfo
            { //not init
                Url = "/Module/Excel-export",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Email] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Extranet] = new LinkInfo
            { //not init
                Url = "/Module/Extranet",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.ExportExternPakket] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.ExportBoekhouding] = new LinkInfo
            { //not init
                Url = "/Module/exportboekhouding",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.HelpDesk] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Handleiding] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Download] = new LinkInfo
            { //not init
                Url = "#",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.WordAddDownload] = new LinkInfo
            { //not init
                Url = "https://download.hybridsaas.com/install/word/setup.exe",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.BrowserDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/hybrid%20saas/Data/Hybrid%20SaaS%20installer.exe",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.OutlookAddDownload] = new LinkInfo
            { //not init
                Url = "http://download.hybridsaas.com/install/office/outlook/",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.KijkMetMijMee] = new LinkInfo
            { //not init
                Url = "http://www.kijkmetmijmee.nl/",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.LicentievoorwaardenPDF] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20licentievoorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.AlgemeeneVoorwaardePDF] = new LinkInfo
            { //not init
                Url = "http://www.hybridsaas.com/images/Algemene%20voorwaarden%20Hybrid%20SaaS%20ICT%20BV.pdf",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.InvoerTicket] = new LinkInfo
            { //not init
                Url = "https://hybridsaas.hybridsaas.com/Extranet-revisited/Ticket/Ticket.create.asp",
                Title = "",
                Description = ""
            };

            LinkDictionary[Link.Gebouwbeheer] = new LinkInfo
            { //not init
                Url = "/Module/Gebouwbeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Prognosebeheer] = new LinkInfo
            {//not init
                Url = "/Module/Prognosebeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Termijnstatenbeheer] = new LinkInfo
            {//not init
                Url = "/Module/Termijnstatenbeheer",
                Title = "",
                Description = ""
            };
            LinkDictionary[Link.Meerwerk] = new LinkInfo
            {//not init
                Url = "/Module/Meerwerk",
                Title = "",
                Description = ""
            };


            foreach (var item in LinkDictionary)
            {
                var file = "C:/Workspace/Ontwikkeling/GitHub/hybridsaas-site" + item.Value.Url + ".cshtml";
                if(!item.Value.Url.Contains("#") && !item.Value.Url.Contains("http"))
                    if (!File.Exists(file))
                    {
                    
                    }
            }
        }
    }
}