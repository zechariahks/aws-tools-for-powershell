/*******************************************************************************
 *  Copyright 2012-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *
 *  AWS Tools for Windows (TM) PowerShell (TM)
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using Amazon.PowerShell.Common;
using Amazon.Runtime;
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

namespace Amazon.PowerShell.Cmdlets.SEC
{
    /// <summary>
    /// Retrieves the contents of the encrypted fields <code>SecretString</code> or <code>SecretBinary</code>
    /// from the specified version of a secret, whichever contains content.
    /// 
    ///  
    /// <para><b>Minimum permissions</b></para><para>
    /// To run this command, you must have the following permissions:
    /// </para><ul><li><para>
    /// secretsmanager:GetSecretValue
    /// </para></li><li><para>
    /// kms:Decrypt - required only if you use a customer-managed Amazon Web Services KMS
    /// key to encrypt the secret. You do not need this permission to use the account's default
    /// Amazon Web Services managed CMK for Secrets Manager.
    /// </para></li></ul><para><b>Related operations</b></para><ul><li><para>
    /// To create a new version of the secret with different encrypted information, use <a>PutSecretValue</a>.
    /// </para></li><li><para>
    /// To retrieve the non-encrypted details for the secret, use <a>DescribeSecret</a>.
    /// </para></li></ul>
    /// </summary>
    [Cmdlet("Get", "SECSecretValue")]
    [OutputType("Amazon.SecretsManager.Model.GetSecretValueResponse")]
    [AWSCmdlet("Calls the AWS Secrets Manager GetSecretValue API operation.", Operation = new[] {"GetSecretValue"}, SelectReturnType = typeof(Amazon.SecretsManager.Model.GetSecretValueResponse))]
    [AWSCmdletOutput("Amazon.SecretsManager.Model.GetSecretValueResponse",
        "This cmdlet returns an Amazon.SecretsManager.Model.GetSecretValueResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class GetSECSecretValueCmdlet : AmazonSecretsManagerClientCmdlet, IExecutor
    {
        
        #region Parameter SecretId
        /// <summary>
        /// <para>
        /// <para>Specifies the secret containing the version that you want to retrieve. You can specify
        /// either the Amazon Resource Name (ARN) or the friendly name of the secret.</para><note><para>If you specify an ARN, we generally recommend that you specify a complete ARN. You
        /// can specify a partial ARN too—for example, if you don’t include the final hyphen and
        /// six random characters that Secrets Manager adds at the end of the ARN when you created
        /// the secret. A partial ARN match can work as long as it uniquely matches only one secret.
        /// However, if your secret has a name that ends in a hyphen followed by six characters
        /// (before Secrets Manager adds the hyphen and six characters to the ARN) and you try
        /// to use that as a partial ARN, then those characters cause Secrets Manager to assume
        /// that you’re specifying a complete ARN. This confusion can cause unexpected results.
        /// To avoid this situation, we recommend that you don’t create secret names ending with
        /// a hyphen followed by six characters.</para><para>If you specify an incomplete ARN without the random suffix, and instead provide the
        /// 'friendly name', you <i>must</i> not include the random suffix. If you do include
        /// the random suffix added by Secrets Manager, you receive either a <i>ResourceNotFoundException</i>
        /// or an <i>AccessDeniedException</i> error, depending on your permissions.</para></note>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true)]
        #else
        [System.Management.Automation.Parameter(Position = 0, ValueFromPipelineByPropertyName = true, ValueFromPipeline = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String SecretId { get; set; }
        #endregion
        
        #region Parameter VersionId
        /// <summary>
        /// <para>
        /// <para>Specifies the unique identifier of the version of the secret that you want to retrieve.
        /// If you specify both this parameter and <code>VersionStage</code>, the two parameters
        /// must refer to the same secret version. If you don't specify either a <code>VersionStage</code>
        /// or <code>VersionId</code> then the default is to perform the operation on the version
        /// with the <code>VersionStage</code> value of <code>AWSCURRENT</code>.</para><para>This value is typically a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value with 32 hexadecimal digits.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VersionId { get; set; }
        #endregion
        
        #region Parameter VersionStage
        /// <summary>
        /// <para>
        /// <para>Specifies the secret version that you want to retrieve by the staging label attached
        /// to the version.</para><para>Staging labels are used to keep track of different versions during the rotation process.
        /// If you specify both this parameter and <code>VersionId</code>, the two parameters
        /// must refer to the same secret version . If you don't specify either a <code>VersionStage</code>
        /// or <code>VersionId</code>, then the default is to perform the operation on the version
        /// with the <code>VersionStage</code> value of <code>AWSCURRENT</code>.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String VersionStage { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecretsManager.Model.GetSecretValueResponse).
        /// Specifying the name of a property of type Amazon.SecretsManager.Model.GetSecretValueResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the SecretId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^SecretId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^SecretId' instead. This parameter will be removed in a future version.")]
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter PassThru { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecretsManager.Model.GetSecretValueResponse, GetSECSecretValueCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.SecretId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.SecretId = this.SecretId;
            #if MODULAR
            if (this.SecretId == null && ParameterWasBound(nameof(this.SecretId)))
            {
                WriteWarning("You are passing $null as a value for parameter SecretId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.VersionId = this.VersionId;
            context.VersionStage = this.VersionStage;
            
            // allow further manipulation of loaded context prior to processing
            PostExecutionContextLoad(context);
            
            var output = Execute(context) as CmdletOutput;
            ProcessOutput(output);
        }
        
        #region IExecutor Members
        
        public object Execute(ExecutorContext context)
        {
            var cmdletContext = context as CmdletContext;
            // create request
            var request = new Amazon.SecretsManager.Model.GetSecretValueRequest();
            
            if (cmdletContext.SecretId != null)
            {
                request.SecretId = cmdletContext.SecretId;
            }
            if (cmdletContext.VersionId != null)
            {
                request.VersionId = cmdletContext.VersionId;
            }
            if (cmdletContext.VersionStage != null)
            {
                request.VersionStage = cmdletContext.VersionStage;
            }
            
            CmdletOutput output;
            
            // issue call
            var client = Client ?? CreateClient(_CurrentCredentials, _RegionEndpoint);
            try
            {
                var response = CallAWSServiceOperation(client, request);
                object pipelineOutput = null;
                pipelineOutput = cmdletContext.Select(response, this);
                output = new CmdletOutput
                {
                    PipelineOutput = pipelineOutput,
                    ServiceResponse = response
                };
            }
            catch (Exception e)
            {
                output = new CmdletOutput { ErrorResponse = e };
            }
            
            return output;
        }
        
        public ExecutorContext CreateContext()
        {
            return new CmdletContext();
        }
        
        #endregion
        
        #region AWS Service Operation Call
        
        private Amazon.SecretsManager.Model.GetSecretValueResponse CallAWSServiceOperation(IAmazonSecretsManager client, Amazon.SecretsManager.Model.GetSecretValueRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Secrets Manager", "GetSecretValue");
            try
            {
                #if DESKTOP
                return client.GetSecretValue(request);
                #elif CORECLR
                return client.GetSecretValueAsync(request).GetAwaiter().GetResult();
                #else
                        #error "Unknown build edition"
                #endif
            }
            catch (AmazonServiceException exc)
            {
                var webException = exc.InnerException as System.Net.WebException;
                if (webException != null)
                {
                    throw new Exception(Utils.Common.FormatNameResolutionFailureMessage(client.Config, webException.Message), webException);
                }
                throw;
            }
        }
        
        #endregion
        
        internal partial class CmdletContext : ExecutorContext
        {
            public System.String SecretId { get; set; }
            public System.String VersionId { get; set; }
            public System.String VersionStage { get; set; }
            public System.Func<Amazon.SecretsManager.Model.GetSecretValueResponse, GetSECSecretValueCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
