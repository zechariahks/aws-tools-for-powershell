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
using Amazon.SageMaker;
using Amazon.SageMaker.Model;

namespace Amazon.PowerShell.Cmdlets.SM
{
    /// <summary>
    /// Creates a <code>Domain</code> used by Amazon SageMaker Studio. A domain consists of
    /// an associated Amazon Elastic File System (EFS) volume, a list of authorized users,
    /// and a variety of security, application, policy, and Amazon Virtual Private Cloud (VPC)
    /// configurations. An Amazon Web Services account is limited to one domain per region.
    /// Users within a domain can share notebook files and other artifacts with each other.
    /// 
    ///  
    /// <para><b>EFS storage</b></para><para>
    /// When a domain is created, an EFS volume is created for use by all of the users within
    /// the domain. Each user receives a private home directory within the EFS volume for
    /// notebooks, Git repositories, and data files.
    /// </para><para>
    /// SageMaker uses the Amazon Web Services Key Management Service (Amazon Web Services
    /// KMS) to encrypt the EFS volume attached to the domain with an Amazon Web Services
    /// managed key by default. For more control, you can specify a customer managed key.
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/encryption-at-rest.html">Protect
    /// Data at Rest Using Encryption</a>.
    /// </para><para><b>VPC configuration</b></para><para>
    /// All SageMaker Studio traffic between the domain and the EFS volume is through the
    /// specified VPC and subnets. For other Studio traffic, you can specify the <code>AppNetworkAccessType</code>
    /// parameter. <code>AppNetworkAccessType</code> corresponds to the network access type
    /// that you choose when you onboard to Studio. The following options are available:
    /// </para><ul><li><para><code>PublicInternetOnly</code> - Non-EFS traffic goes through a VPC managed by Amazon
    /// SageMaker, which allows internet access. This is the default value.
    /// </para></li><li><para><code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets.
    /// Internet access is disabled by default. To allow internet access, you must specify
    /// a NAT gateway.
    /// </para><para>
    /// When internet access is disabled, you won't be able to run a Studio notebook or to
    /// train or host models unless your VPC has an interface endpoint to the SageMaker API
    /// and runtime or a NAT gateway and your security groups allow outbound connections.
    /// </para></li></ul><important><para>
    /// NFS traffic over TCP on port 2049 needs to be allowed in both inbound and outbound
    /// rules in order to launch a SageMaker Studio app successfully.
    /// </para></important><para>
    /// For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/studio-notebooks-and-internet-access.html">Connect
    /// SageMaker Studio Notebooks to Resources in a VPC</a>.
    /// </para>
    /// </summary>
    [Cmdlet("New", "SMDomain", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("Amazon.SageMaker.Model.CreateDomainResponse")]
    [AWSCmdlet("Calls the Amazon SageMaker Service CreateDomain API operation.", Operation = new[] {"CreateDomain"}, SelectReturnType = typeof(Amazon.SageMaker.Model.CreateDomainResponse))]
    [AWSCmdletOutput("Amazon.SageMaker.Model.CreateDomainResponse",
        "This cmdlet returns an Amazon.SageMaker.Model.CreateDomainResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class NewSMDomainCmdlet : AmazonSageMakerClientCmdlet, IExecutor
    {
        
        #region Parameter AppNetworkAccessType
        /// <summary>
        /// <para>
        /// <para>Specifies the VPC used for non-EFS traffic. The default value is <code>PublicInternetOnly</code>.</para><ul><li><para><code>PublicInternetOnly</code> - Non-EFS traffic is through a VPC managed by Amazon
        /// SageMaker, which allows direct internet access</para></li><li><para><code>VpcOnly</code> - All Studio traffic is through the specified VPC and subnets</para></li></ul>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [AWSConstantClassSource("Amazon.SageMaker.AppNetworkAccessType")]
        public Amazon.SageMaker.AppNetworkAccessType AppNetworkAccessType { get; set; }
        #endregion
        
        #region Parameter AuthMode
        /// <summary>
        /// <para>
        /// <para>The mode of authentication that members use to access the domain.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [AWSConstantClassSource("Amazon.SageMaker.AuthMode")]
        public Amazon.SageMaker.AuthMode AuthMode { get; set; }
        #endregion
        
        #region Parameter DefaultUserSetting
        /// <summary>
        /// <para>
        /// <para>The default settings to use to create a user profile when <code>UserSettings</code>
        /// isn't specified in the call to the <code>CreateUserProfile</code> API.</para><para><code>SecurityGroups</code> is aggregated when specified in both calls. For all other
        /// settings in <code>UserSettings</code>, the values specified in <code>CreateUserProfile</code>
        /// take precedence over those specified in <code>CreateDomain</code>.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("DefaultUserSettings")]
        public Amazon.SageMaker.Model.UserSettings DefaultUserSetting { get; set; }
        #endregion
        
        #region Parameter DomainName
        /// <summary>
        /// <para>
        /// <para>A name for the domain.</para>
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
        public System.String DomainName { get; set; }
        #endregion
        
        #region Parameter KmsKeyId
        /// <summary>
        /// <para>
        /// <para>SageMaker uses Amazon Web Services KMS to encrypt the EFS volume attached to the domain
        /// with an Amazon Web Services managed key by default. For more control, specify a customer
        /// managed key.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String KmsKeyId { get; set; }
        #endregion
        
        #region Parameter SubnetId
        /// <summary>
        /// <para>
        /// <para>The VPC subnets that Studio uses for communication.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyCollection]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        [Alias("SubnetIds")]
        public System.String[] SubnetId { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Tags to associated with the Domain. Each tag consists of a key and an optional value.
        /// Tag keys must be unique per resource. Tags are searchable using the <code>Search</code>
        /// API.</para><para>Tags that you specify for the Domain are also added to all Apps that the Domain launches.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.SageMaker.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter VpcId
        /// <summary>
        /// <para>
        /// <para>The ID of the Amazon Virtual Private Cloud (VPC) that Studio uses for communication.</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowEmptyString]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.String VpcId { get; set; }
        #endregion
        
        #region Parameter HomeEfsFileSystemKmsKeyId
        /// <summary>
        /// <para>
        /// <para>This member is deprecated and replaced with <code>KmsKeyId</code>.</para>
        /// </para>
        /// <para>This parameter is deprecated.</para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [System.ObsoleteAttribute("This property is deprecated, use KmsKeyId instead.")]
        public System.String HomeEfsFileSystemKmsKeyId { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.SageMaker.Model.CreateDomainResponse).
        /// Specifying the name of a property of type Amazon.SageMaker.Model.CreateDomainResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the DomainName parameter.
        /// The -PassThru parameter is deprecated, use -Select '^DomainName' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^DomainName' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.DomainName), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "New-SMDomain (CreateDomain)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.SageMaker.Model.CreateDomainResponse, NewSMDomainCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.DomainName;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.AppNetworkAccessType = this.AppNetworkAccessType;
            context.AuthMode = this.AuthMode;
            #if MODULAR
            if (this.AuthMode == null && ParameterWasBound(nameof(this.AuthMode)))
            {
                WriteWarning("You are passing $null as a value for parameter AuthMode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DefaultUserSetting = this.DefaultUserSetting;
            #if MODULAR
            if (this.DefaultUserSetting == null && ParameterWasBound(nameof(this.DefaultUserSetting)))
            {
                WriteWarning("You are passing $null as a value for parameter DefaultUserSetting which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.DomainName = this.DomainName;
            #if MODULAR
            if (this.DomainName == null && ParameterWasBound(nameof(this.DomainName)))
            {
                WriteWarning("You are passing $null as a value for parameter DomainName which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.HomeEfsFileSystemKmsKeyId = this.HomeEfsFileSystemKmsKeyId;
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.KmsKeyId = this.KmsKeyId;
            if (this.SubnetId != null)
            {
                context.SubnetId = new List<System.String>(this.SubnetId);
            }
            #if MODULAR
            if (this.SubnetId == null && ParameterWasBound(nameof(this.SubnetId)))
            {
                WriteWarning("You are passing $null as a value for parameter SubnetId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.SageMaker.Model.Tag>(this.Tag);
            }
            context.VpcId = this.VpcId;
            #if MODULAR
            if (this.VpcId == null && ParameterWasBound(nameof(this.VpcId)))
            {
                WriteWarning("You are passing $null as a value for parameter VpcId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.SageMaker.Model.CreateDomainRequest();
            
            if (cmdletContext.AppNetworkAccessType != null)
            {
                request.AppNetworkAccessType = cmdletContext.AppNetworkAccessType;
            }
            if (cmdletContext.AuthMode != null)
            {
                request.AuthMode = cmdletContext.AuthMode;
            }
            if (cmdletContext.DefaultUserSetting != null)
            {
                request.DefaultUserSettings = cmdletContext.DefaultUserSetting;
            }
            if (cmdletContext.DomainName != null)
            {
                request.DomainName = cmdletContext.DomainName;
            }
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (cmdletContext.HomeEfsFileSystemKmsKeyId != null)
            {
                request.HomeEfsFileSystemKmsKeyId = cmdletContext.HomeEfsFileSystemKmsKeyId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (cmdletContext.KmsKeyId != null)
            {
                request.KmsKeyId = cmdletContext.KmsKeyId;
            }
            if (cmdletContext.SubnetId != null)
            {
                request.SubnetIds = cmdletContext.SubnetId;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.VpcId != null)
            {
                request.VpcId = cmdletContext.VpcId;
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
        
        private Amazon.SageMaker.Model.CreateDomainResponse CallAWSServiceOperation(IAmazonSageMaker client, Amazon.SageMaker.Model.CreateDomainRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon SageMaker Service", "CreateDomain");
            try
            {
                #if DESKTOP
                return client.CreateDomain(request);
                #elif CORECLR
                return client.CreateDomainAsync(request).GetAwaiter().GetResult();
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
            public Amazon.SageMaker.AppNetworkAccessType AppNetworkAccessType { get; set; }
            public Amazon.SageMaker.AuthMode AuthMode { get; set; }
            public Amazon.SageMaker.Model.UserSettings DefaultUserSetting { get; set; }
            public System.String DomainName { get; set; }
            [System.ObsoleteAttribute]
            public System.String HomeEfsFileSystemKmsKeyId { get; set; }
            public System.String KmsKeyId { get; set; }
            public List<System.String> SubnetId { get; set; }
            public List<Amazon.SageMaker.Model.Tag> Tag { get; set; }
            public System.String VpcId { get; set; }
            public System.Func<Amazon.SageMaker.Model.CreateDomainResponse, NewSMDomainCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
