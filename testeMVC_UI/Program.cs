using System;
using testeMVC_BC;
using testeMVC_SI;
using testeMVC_BEC;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace testeMVC_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonSerializer.Serialize(MOQ_objects()));
            Console.ReadKey();
        }

        static Product_BEC MOQ_objects()
        {
            Product_BEC product = new Product_BEC();
            product.Sku = 43264;
            product.Name = "Batata frita Ruffles Cebola &Salsa";
            product.isMarketable = true;


            Warehouses_BEC warehouse1 = new Warehouses_BEC();
            warehouse1.Quantity = 12;
            warehouse1.Locality = Locality_enum.Localities.SP;
            warehouse1.Type = Type_enum.Types.ECOMMERCE;


            Warehouses_BEC warehouse2 = new Warehouses_BEC();
            warehouse2.Quantity = 3;
            warehouse2.Locality = Locality_enum.Localities.MOEMA;
            warehouse2.Type = Type_enum.Types.PHYSICAL_STORE;



            inventory_BEC inventory = new inventory_BEC();
            inventory.Quantity = 15;
            inventory.Warehouses = new List<Warehouses_BEC>();
            inventory.Warehouses.Add(warehouse1);
            inventory.Warehouses.Add(warehouse2);

            product.inventory = inventory;

            return product;
        }
    }


}

