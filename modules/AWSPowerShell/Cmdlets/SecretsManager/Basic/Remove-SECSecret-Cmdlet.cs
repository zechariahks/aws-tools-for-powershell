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
    /// Deletes an entire secret and all of the versions. You can optionally include a recovery
    /// window during which you can restore the secret. If you don't specify a recovery window
    /// value, the operation defaults to 30 days. Secrets Manager attaches a <code>DeletionDate</code>
    /// stamp to the secret that specifies the end of the recovery window. At the end of the
    /// recovery window, Secrets Manager deletes the secret permanently.
    /// 
    ///  
    /// <para>
    /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
    /// the <code>DeletionDate</code> and cancel the deletion of the secret.
    /// </para><para>
    /// You cannot access the encrypted secret information in any secret scheduled for deletion.
    /// If you need to access that information, you must cancel the deletion with <a>RestoreSecret</a>
    /// and then retrieve the information.
    /// </para><note><ul><li><para>
    /// There is no explicit operation to delete a version of a secret. Instead, remove all
    /// staging labels from the <code>VersionStage</code> field of a version. That marks the
    /// version as deprecated and allows Secrets Manager to delete it as needed. Versions
    /// without any staging labels do not show up in <a>ListSecretVersionIds</a> unless you
    /// specify <code>IncludeDeprecated</code>.
    /// </para></li><li><para>
    /// The permanent secret deletion at the end of the waiting period is performed as a background
    /// task with low priority. There is no guarantee of a specific time after the recovery
    /// window for the actual delete operation to occur.
    /// </para></li></ul></note><para><b>Minimum permissions</b></para><para>
    /// To run this command, you must have the following permissions:
    /// </para><ul><li><para>
    /// secretsmanager:DeleteSecret
    /// </para></li></ul><para><b>Related operations</b></para><ul><li><para>
    /// To create a secret, use <a>CreateSecret</a>.
    /// </para></li><li><para>
    /// To cancel deletion of a version of a secret before the recovery window has expired,
    /// use <a>RestoreSecret</a>.
    /// </para></li></ul>
    /// </summary>
    [Cmdlet("Remove", "SECSecret", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    [OutputType("Amazon.SecretsManager.Model.DeleteSecretResponse")]
    [AWSCmdlet("Calls the AWS Secrets Manager DeleteSecret API operation.", Operation = new[] {"DeleteSecret"}, SelectReturnType = typeof(Amazon.SecretsManager.Model.DeleteSecretResponse))]
    [AWSCmdletOutput("Amazon.SecretsManager.Model.DeleteSecretResponse",
        "This cmdlet returns an Amazon.SecretsManager.Model.DeleteSecretResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RemoveSECSecretCmdlet : AmazonSecretsManagerClientCmdlet, IExecutor
    {
        
        #region Parameter DeleteWithNoRecovery
        /// <summary>
        /// <para>
        /// <para>(Optional) Specifies that the secret is to be deleted without any recovery window.
        /// You can't use both this parameter and the <code>RecoveryWindowInDays</code> parameter
        /// in the same API call.</para><para>An asynchronous background process performs the actual deletion, so there can be a
        /// short delay before the operation completes. If you write code to delete and then immediately
        /// recreate a secret with the same name, ensure that your code includes appropriate back
        /// off and retry logic.</para><important><para>Use this parameter with caution. This parameter causes the operation to skip the normal
        /// waiting period before the permanent deletion that Amazon Web Services would normally
        /// impose with the <code>RecoveryWindowInDays</code> parameter. If you delete a secret
        /// with the <code>ForceDeleteWithouRecovery</code> parameter, then you have no opportunity
        /// to recover the secret. You lose the secret permanently.</para></important><important><para>If you use this parameter and include a previously deleted or nonexistent secret,
        /// the operation does not return the error <code>ResourceNotFoundException</code> in
        /// order to correctly handle retries.</para></important>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? DeleteWithNoRecovery { get; set; }
        #endregion
        
        #region Parameter RecoveryWindowInDay
        /// <summary>
        /// <para>
        /// <para>(Optional) Specifies the number of days that Secrets Manager waits before Secrets
        /// Manager can delete the secret. You can't use both this parameter and the <code>ForceDeleteWithoutRecovery</code>
        /// parameter in the same API call.</para><para>This value can range from 7 to 30 days with a default value of 30.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("RecoveryWindowInDays")]
        public System.Int64? RecoveryWindowInDay { get; set; }
        #endregion
        
        #region Parameter SecretId
        /// <summary>
        /// <para>
        /// <para>Specifies the secret to delete. You can specify either the Amazon Resource Name (ARN)
        /// or the friendly name of the secret.</para><note><para>If you specify an ARN, we generally recommend that you specify a complete ARN. You
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
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SecretsManager.Model.DeleteSecretResponse).
        /// Specifying the name of a property of type Amazon.SecretsManager.Model.DeleteSecretResponse will result in that property being returned.
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
        
        #region Parameter Force
        /// <summary>
        /// This parameter overrides confirmation prompts to force 
        /// the cmdlet to continue its operation. This parameter should always
        /// be used with caution.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public SwitchParameter Force { get; set; }
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.SecretId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Remove-SECSecret (DeleteSecret)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SecretsManager.Model.DeleteSecretResponse, RemoveSECSecretCmdlet>(Select) ??
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
            context.DeleteWithNoRecovery = this.DeleteWithNoRecovery;
            context.RecoveryWindowInDay = this.RecoveryWindowInDay;
            context.SecretId = this.SecretId;
            #if MODULAR
            if (this.SecretId == null && ParameterWasBound(nameof(this.SecretId)))
            {
                WriteWarning("You are passing $null as a value for parameter SecretId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            
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
            var request = new Amazon.SecretsManager.Model.DeleteSecretRequest();
            
            if (cmdletContext.DeleteWithNoRecovery != null)
            {
                request.ForceDeleteWithoutRecovery = cmdletContext.DeleteWithNoRecovery.Value;
            }
            if (cmdletContext.RecoveryWindowInDay != null)
            {
                request.RecoveryWindowInDays = cmdletContext.RecoveryWindowInDay.Value;
            }
            if (cmdletContext.SecretId != null)
            {
                request.SecretId = cmdletContext.SecretId;
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
        
        private Amazon.SecretsManager.Model.DeleteSecretResponse CallAWSServiceOperation(IAmazonSecretsManager client, Amazon.SecretsManager.Model.DeleteSecretRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS Secrets Manager", "DeleteSecret");
            try
            {
                #if DESKTOP
                return client.DeleteSecret(request);
                #elif CORECLR
                return client.DeleteSecretAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? DeleteWithNoRecovery { get; set; }
            public System.Int64? RecoveryWindowInDay { get; set; }
            public System.String SecretId { get; set; }
            public System.Func<Amazon.SecretsManager.Model.DeleteSecretResponse, RemoveSECSecretCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
