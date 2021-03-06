﻿using Data_layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data_layer
{
    public class DbInitialiser
    {
        public static void Initialize(DatabaseContext context)
        {
            //context.Database.Migrate();
            //Create the db if not yet exists
            context.Database.EnsureCreated();

            if (context.Trajecten.Count() == 0)
            {
                Cursus[] cursussen =
                {
                    new Cursus()
                    {
                        Titel = "dotNET cursus",
                        Type = ".NET",
                        Prijs = 15.45,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://52bec9fb483231ac1c712343-jebebgcvzf.stackpathdns.com/wp-content/uploads/2016/05/dotnet.jpg",
                        OrderNumber = 1
                    },
                    new Cursus()
                    {
                        Titel = "dotNET cursus2",
                        Type = ".NET",
                        Prijs = 45.45,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://52bec9fb483231ac1c712343-jebebgcvzf.stackpathdns.com/wp-content/uploads/2016/05/dotnet.jpg",
                        OrderNumber = 2
                    },
                    new Cursus()
                    {
                        Titel = "React cursus",
                        Type = "Web Development",
                        Prijs = 19.35,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://ionicframework.com/blog/wp-content/uploads/2019/02/react-beta.png",
                        OrderNumber = 3
                    },
                    new Cursus()
                    {
                        Titel = "Angular cursus",
                        Type = "Web Development",
                        Prijs = 21.45,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://miro.medium.com/max/750/1*8hD4eYuELoWAbQLNnjQ4mA.jpeg",
                        OrderNumber = 4
                    },
                    new Cursus()
                    {
                        Titel = "ReactJS cursus",
                        Type = "Web Development",
                        Prijs = 36.50,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://ionicframework.com/blog/wp-content/uploads/2019/02/react-beta.png",
                        OrderNumber = 5
                    },
                    new Cursus()
                    {
                        Titel = "Vue cursus",
                        Type = "Web Development",
                        Prijs = 10.25,
                        Beschrijving = "Some example text some ...",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        FotoURLCard = "https://miro.medium.com/max/1200/1*-PlqbnwqjqJi_EVmrhmuDQ.jpeg",
                        OrderNumber = 6
                    }
                };
                Traject[] trajecten =
                {
                    new Traject()
                    {
                        Cursussen = new List<Cursus>()
                        {
                            cursussen[0],
                            cursussen[1]
                        },
                        Titel = "Complete Full Stack Traject #0",
                        Type = "Full Stack",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Prijs = 50,
                        Beschrijving = "Some example text some example text.",
                        FotoURLCard = "https://via.placeholder.com/450x350.png/09f/fff?text=Foto van een product",
                        OrderNumber = 1
                    },
                    new Traject()
                    {
                        Cursussen = new List<Cursus>()
                        {
                            cursussen[2],
                            cursussen[3]
                        },
                        Titel = "Complete Full Stack Traject #1",
                        Type = "Full Stack",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Prijs = 50,
                        Beschrijving = "Some example text some example text.",
                        FotoURLCard = "https://via.placeholder.com/450x350.png/09f/fff?text=Foto van een product",
                        OrderNumber = 2
                    },
                    new Traject()
                    {
                        Cursussen = new List<Cursus>()
                        {
                            cursussen[4],
                            cursussen[5]
                        },
                        Titel = "Complete Full Stack Traject #2",
                        Type = "Full Stack",
                        LangeBeschrijving ="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        Prijs = 50,
                        Beschrijving = "Some example text some example text.",
                        FotoURLCard = "https://via.placeholder.com/450x350.png/09f/fff?text=Foto van een product",
                        OrderNumber = 3
                    }
                };

                Klant[] klanten =
                {
                    new Klant()
                    {
                        AzureId = "aaa"
                    },
                    new Klant()
                    {
                        AzureId = "b3ce667f-2829-481a-8ebb-f6bea8cde84b"
                    },
                    new Klant()
                    {
                        AzureId = "e798f80f-a4e4-4042-8d47-0c9695b42e59"
                    }
                };

                Winkelwagen[] winkelwagens =
                {
                    new Winkelwagen()
                    {
                        Klant = klanten[0],
                        Producten = new List<WinkelwagenItem>()
                        {
                            new WinkelwagenItem()
                            {
                                Aantal = 2,
                                Product = trajecten[0]
                            },
                            new WinkelwagenItem()
                            {
                                Aantal = 3,
                                Product = cursussen[0]
                            },
                            new WinkelwagenItem()
                            {
                                Aantal = 1,
                                Product = cursussen[1]
                            }
                        },
                        Datum = new DateTime()
                    }
                };
                Bestelling[] bestellingen =
                {
                    new Bestelling()
                    {
                        Klant = klanten[2],
                        Datum = DateTime.Now,
                        TotaalPrijs = 100,
                        Producten = new List<BestellingItem>()
                        {
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = cursussen[0]
                            },
                            new BestellingItem()
                            {
                                Aantal = 2,
                                Product = cursussen[1]
                            },
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = trajecten[0]
                            }
                        }
                    },
                    new Bestelling()
                    {
                        Klant = klanten[2],
                        Datum = DateTime.Now,
                        TotaalPrijs = 100,
                        Producten = new List<BestellingItem>()
                        {
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = cursussen[2]
                            },
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = cursussen[3]
                            }
                        }
                    },
                    new Bestelling()
                    {
                        Klant = klanten[2],
                        Datum = DateTime.Now,
                        TotaalPrijs = 100,
                        Producten = new List<BestellingItem>()
                        {
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = cursussen[4]
                            },
                            new BestellingItem()
                            {
                                Aantal = 1,
                                Product = cursussen[5]
                            }
                        }
                    }
                };
                foreach (Bestelling bestelling in bestellingen)
                {
                    context.Bestellingen.Add(bestelling);
                }
                foreach (Winkelwagen winkelwagen in winkelwagens)
                {
                    context.Winkelwagens.Add(winkelwagen);
                }
                foreach (Klant klant in klanten)
                {
                    context.Klanten.Add(klant);
                }
                foreach (Cursus cursus in cursussen)
                {
                    context.Cursussen.Add(cursus);
                }
                foreach (Traject traject in trajecten)
                {
                    context.Trajecten.Add(traject);
                }
                context.SaveChanges();
            }
        }
    }
}
