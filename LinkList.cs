using System;
using System.Collections.Generic;
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
    }

    public static class LinkList
    {
        public class LinkInfo
        {
            public string Url;
        }

        static Dictionary<Link, LinkInfo> LinkDictionary = new Dictionary<Link, LinkInfo>();

        static LinkList()
        {
            LinkDictionary[Link.Commisie] = new LinkInfo
            {
                Url = "/Comissie"
            };
            LinkDictionary[Link.Contact] = new LinkInfo
            {
                Url = "/contact"
            };
            LinkDictionary[Link.Factsheet] = new LinkInfo
            {
                Url = "/Factsheet"
            };
            LinkDictionary[Link.Financieel] = new LinkInfo
            {
                Url = "/Financieel"
            };
            LinkDictionary[Link.Index] = new LinkInfo
            {
                Url = "/index"
            };
            LinkDictionary[Link.Module] = new LinkInfo
            {
                Url = "/module"
            };
            LinkDictionary[Link.Molules] = new LinkInfo
            {
                Url = "/modules"
            };
            LinkDictionary[Link.PakketContactbeheer] = new LinkInfo
            {
                Url = "/pakket-contactbeheer"
            };
            LinkDictionary[Link.PakketOfferteVoorraad] = new LinkInfo
            {
                Url = "/pakket-offerte-voorraad"
            };
            LinkDictionary[Link.Pakketten] = new LinkInfo
            {
                Url = "/pakketten"
            };
            LinkDictionary[Link.PakketTicketsFacturatie] = new LinkInfo
            {
                Url = "/pakket-tickets-facturatie"
            };
            LinkDictionary[Link.ReleaseNotes] = new LinkInfo
            {
                Url = "/releasenotes"
            };
            LinkDictionary[Link.Support] = new LinkInfo
            {
                Url = "/support"
            };
            LinkDictionary[Link.TicketSysteem] = new LinkInfo
            {
                Url = "/ticket-systeem"
            };
            LinkDictionary[Link.Webshop] = new LinkInfo
            {
                Url = "/webshop"
            };
            LinkDictionary[Link.Over] = new LinkInfo
            {
                Url = "/over"
            };
            LinkDictionary[Link.Blog] = new LinkInfo
            {
                Url = "/blog"
            };
            LinkDictionary[Link.Youtube] = new LinkInfo
            {
                Url = "https://www.youtube.com/user/HybridSaaSMovie"
            };
            LinkDictionary[Link.Twitter] = new LinkInfo
            {
                Url = "https://twitter.com/hybridsaas"
            };
            LinkDictionary[Link.Facebook] = new LinkInfo
            {
                Url = "https://www.facebook.com/hybridsaas"
            };
            LinkDictionary[Link.SiteMap] = new LinkInfo
            {
                Url = "/site-map"
            };
            LinkDictionary[Link.AlgemeeneVoorwaarde] = new LinkInfo
            {
                Url = "/algemeene-voorwaarde"
            };
            LinkDictionary[Link.GooglePlus] = new LinkInfo
            {
                Url = "https://plus.google.com/117276878800045230964/posts"
            };
        }

        public static string GetLink(Link link)
        {
            return LinkDictionary[link].Url;
        }
    }
}