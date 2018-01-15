using System;
using System.Collections;
using Microsoft.Win32;


namespace SquadronAddIns.Default.SharePointSKU
{
    public class SKUFinder
    {
        internal static Hashtable _products;

        public static Hashtable SharePointProducts
        {
            get
            {
                if (_products == null)
                {
                    _products = new Hashtable();

                    _products.Add("BEED1F75-C398-4447-AEF1-E66E1F0DF91E", "SharePoint Foundation 2010");
                    _products.Add("1328E89E-7EC8-4F7E-809E-7E945796E511", "Search Server Express 2010");

                    _products.Add("B2C0B444-3914-4ACB-A0B8-7CF50A8F7AA0", "SharePoint Server 2010 Standard Trial");
                    _products.Add("3FDFBCC8-B3E4-4482-91FA-122C6432805C", "SharePoint Server 2010 Standard");
                    _products.Add("88BED06D-8C6B-4E62-AB01-546D6005FE97", "SharePoint Server 2010 Enterprise Trial");
                    _products.Add("D5595F62-449B-4061-B0B2-0CBAD410BB51", "SharePoint Server 2010 Enterprise");

                    _products.Add("BC4C1C97-9013-4033-A0DD-9DC9E6D6C887", "Search Server 2010 Trial");
                    _products.Add("08460AA2-A176-442C-BDCA-26928704D80B", "Search Server 2010");

                    _products.Add("84902853-59F6-4B20-BC7C-DE4F419FEFAD", "Project Server 2010 Trial");
                    _products.Add("ED21638F-97FF-4A65-AD9B-6889B93065E2", "Project Server 2010");

                    _products.Add("926E4E17-087B-47D1-8BD7-91A394BC6196", "Office Web Companions 2010");
                }

                return _products;
            }
        }

        private const String SharePointProductsRegistryPath = @"SOFTWARE\Microsoft\Shared Tools\Web Server Extensions\14.0\WSS\InstalledProducts\";

        public static string Execute()
        {
            string result = "Unknown";
            try
            {
                //Open the registry key in read-only mode.
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(SharePointProductsRegistryPath, false))
                {
                    //Get all of the installed product code/SKUId pairs.
                    foreach (String value in key.GetValueNames())
                    {
                        try
                        {
                            //Get the SKUId and see whether it is a known product.
                            String SKUId = key.GetValue(value) as String;

                            if (SharePointProducts[SKUId] != null)
                            {
                                result = string.Format("Product Installed: {0}", SharePointProducts[SKUId]);
                            }
                            else
                            {
                                result = string.Format("Unknown Product: {0}", SKUId);
                            }
                        }
                        catch (Exception e)
                        {
                            result = string.Format("Could not read key exception was {0}", e.Message);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                result = string.Format("Could not open key exception was {0}", e.Message);
            }

            return result;
        }
    }
}
