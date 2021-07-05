using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IndexerTest
{
    public class OnlineStore
    {
        Product[] Products = null;

        public OnlineStore()
        {
            Products = new Product[9];
            Products[0] = new Product
            {
                ProductId = 100,
                ProductName = "Base Ball",
                Price = 7.5,
                Category = CategoryType.SPORTS,
                Description = "Ball with a instrument Base drawing on."
            };

            Products[1] = new Product
            {
                ProductId = 120,
                ProductName = "Tennis Net",
                Price = 25.79,
                Category = CategoryType.SPORTS,
                Description = "A boy named Tennis's custom net."
            };

            Products[2] = new Product
            {
                ProductId = 175,
                ProductName = "Soccer Ball",
                Price = 9.13,
                Category = CategoryType.SPORTS,
                Description = "Amazing normal soccer ball."
            };

            Products[3] = new Product
            {
                ProductId = 209,
                ProductName = "Parry Hotter ",
                Price = 13.26,
                Category = CategoryType.BOOKS,
                Description = "This has nothing to do with the Harry Potter."
            };

            Products[4] = new Product
            {
                ProductId = 213,
                ProductName = "The Secound Great Batsgy",
                Price = 12.10,
                Category = CategoryType.BOOKS,
                Description = "No one is interested in the second greatest man!"
            };

            Products[5] = new Product
            {
                ProductId = 287,
                ProductName = "Vincible Man",
                Price = 9.89,
                Category = CategoryType.BOOKS,
                Description = "He is always vincible."
            };

            Products[6] = new Product
            {
                ProductId = 328,
                ProductName = "youPod Pro",
                Price = 246.25,
                Category = CategoryType.ELECTRONICS,
                Description = "Hey you! This is time to try the YOUPOD PRO."
            };

            Products[7] = new Product
            {
                ProductId = 366,
                ProductName = "Projector",
                Price = 99.99,
                Category = CategoryType.ELECTRONICS,
                Description = "Projector used in a box."
            };

            Products[8] = new Product
            {
                ProductId = 397,
                ProductName = "Smartphone Printer",
                Price = 202.10,
                Category = CategoryType.ELECTRONICS,
                Description = "You could print out how your phone looks like."
            };

        }

        public Product[] this[int idToSearch, ProductPropertyType pType]
        {
            get
            {
                ArrayList MatchList = new ArrayList();
               
                foreach(Product p in Products)
                {
                    if (pType == ProductPropertyType.PRODUCT_ID)
                    {

                        if (p.ProductId == idToSearch)
                        {
                            MatchList.Add(p);
                            break;
                        }
                    }else if (pType == ProductPropertyType.PRODUCT_CATEGORY)
                    {
                        if (p.Category == (CategoryType)idToSearch)
                        {
                            MatchList.Add(p);
                        }
                    }
                }
                return (Product[])MatchList.ToArray(typeof(Product));

            }
        }

        
        public Product[] this[string strToSearch , ProductPropertyType strType]
        {
            get
            {
                ArrayList MatchList = new ArrayList();
                foreach(Product p in Products)
                {
                    if (strType == ProductPropertyType.PRODUCT_NAME)
                    {
                        if (p.ProductName.ToLower() == strToSearch.ToLower())
                        {
                            MatchList.Add(p);
                        }
                    }else if(strType == ProductPropertyType.PRODUCT_DESCRIPTION)
                    {
                        if (p.Description.ToLower().Contains(strToSearch.ToLower()))
                        {
                            MatchList.Add(p);
                        }
                    }
                }
                return (Product[])MatchList.ToArray(typeof(Product));
            }
        }
    }
}
