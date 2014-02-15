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
    /// Implements the abstract AWSCredentials class
    /// </summary>
    class GlacierLoginCredentials : AWSCredentials
    {

        private GlacierLoginCredentials()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">The AWS Secret Access Key</param>
        /// <param name="token">optional: Session credentials</param>
        public GlacierLoginCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
            : this()
        {
            this.cred = new ImmutableCredentials(awsAccessKeyId, awsSecretAccessKey, token);
        }

        private ImmutableCredentials cred;

        public override ImmutableCredentials GetCredentials()
        {
            return this.cred;
        }
    }
}
