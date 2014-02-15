using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Glacier;
using Amazon.Runtime;
using Amazon.Glacier.Transfer;

namespace provider_AGlacier
{
    /// <summary>
    /// Provides operations for Amazon Glacier Services
    /// </summary>
    public class provider_AGlacier
    {
        /// <summary>
        /// Uploads an archive to the specified location
        /// </summary>
        /// <param name="vaultName">The Vault to which the archive will be added</param>
        /// <param name="archiveToUploadPath">Path to the archive to upload</param>
        /// <param name="archiveDescription">Additional Description for the archive</param>
        /// <param name="region">Galcier Region where the Vault is located</param>
        /// <param name="archiveID">Archive specific ID, give by the Amazon Service</param>
        /// <returns>Successfully uploaded</returns>
        public static bool UploadArchiveToVault(string vaultName, string archiveToUploadPath, string archiveDescription,GlacierLoginCredentials credentials, Amazon.RegionEndpoint region, out string archiveID)
        {
            try
            {
                ////Create Transfer Manager
                var manager = new ArchiveTransferManager(credentials,region);


                archiveID = manager.Upload(vaultName, archiveDescription, archiveToUploadPath).ArchiveId;
            }
            catch(Exception ex)
            {
    
                archiveID = String.Empty;

                return false;
            }
            return true;
        }


        public static bool DownloadArchiveFromVault(string vaultName)
        {
           
        }
    }

    
}
