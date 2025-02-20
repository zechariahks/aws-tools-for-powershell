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
using Amazon.IoT;
using Amazon.IoT.Model;

namespace Amazon.PowerShell.Cmdlets.IOT
{
    /// <summary>
    /// Registers a CA certificate with IoT. This CA certificate can then be used to sign
    /// device certificates, which can be then registered with IoT. You can register up to
    /// 10 CA certificates per Amazon Web Services account that have the same subject field.
    /// This enables you to have up to 10 certificate authorities sign your device certificates.
    /// If you have more than one CA certificate registered, make sure you pass the CA certificate
    /// when you register your device certificates with the <a>RegisterCertificate</a> action.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterCACertificate</a>
    /// action.
    /// </para>
    /// </summary>
    [Cmdlet("Register", "IOTCACertificate")]
    [OutputType("Amazon.IoT.Model.RegisterCACertificateResponse")]
    [AWSCmdlet("Calls the AWS IoT RegisterCACertificate API operation.", Operation = new[] {"RegisterCACertificate"}, SelectReturnType = typeof(Amazon.IoT.Model.RegisterCACertificateResponse))]
    [AWSCmdletOutput("Amazon.IoT.Model.RegisterCACertificateResponse",
        "This cmdlet returns an Amazon.IoT.Model.RegisterCACertificateResponse object containing multiple properties. The object can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class RegisterIOTCACertificateCmdlet : AmazonIoTClientCmdlet, IExecutor
    {
        
        #region Parameter AllowAutoRegistration
        /// <summary>
        /// <para>
        /// <para>Allows this CA certificate to be used for auto registration of device certificates.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? AllowAutoRegistration { get; set; }
        #endregion
        
        #region Parameter CaCertificate
        /// <summary>
        /// <para>
        /// <para>The CA certificate.</para>
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
        public System.String CaCertificate { get; set; }
        #endregion
        
        #region Parameter RegistrationConfig_RoleArn
        /// <summary>
        /// <para>
        /// <para>The ARN of the role.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RegistrationConfig_RoleArn { get; set; }
        #endregion
        
        #region Parameter SetAsActive
        /// <summary>
        /// <para>
        /// <para>A boolean value that specifies if the CA certificate is set to active.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.Boolean? SetAsActive { get; set; }
        #endregion
        
        #region Parameter Tag
        /// <summary>
        /// <para>
        /// <para>Metadata which can be used to manage the CA certificate.</para><note><para>For URI Request parameters use format: ...key1=value1&amp;key2=value2...</para><para>For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."</para><para>For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."</para></note>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("Tags")]
        public Amazon.IoT.Model.Tag[] Tag { get; set; }
        #endregion
        
        #region Parameter RegistrationConfig_TemplateBody
        /// <summary>
        /// <para>
        /// <para>The template body.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public System.String RegistrationConfig_TemplateBody { get; set; }
        #endregion
        
        #region Parameter VerificationCertificate
        /// <summary>
        /// <para>
        /// <para>The private key verification certificate.</para>
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
        public System.String VerificationCertificate { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is '*'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoT.Model.RegisterCACertificateResponse).
        /// Specifying the name of a property of type Amazon.IoT.Model.RegisterCACertificateResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoT.Model.RegisterCACertificateResponse, RegisterIOTCACertificateCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
            }
            context.AllowAutoRegistration = this.AllowAutoRegistration;
            context.CaCertificate = this.CaCertificate;
            #if MODULAR
            if (this.CaCertificate == null && ParameterWasBound(nameof(this.CaCertificate)))
            {
                WriteWarning("You are passing $null as a value for parameter CaCertificate which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.RegistrationConfig_RoleArn = this.RegistrationConfig_RoleArn;
            context.RegistrationConfig_TemplateBody = this.RegistrationConfig_TemplateBody;
            context.SetAsActive = this.SetAsActive;
            if (this.Tag != null)
            {
                context.Tag = new List<Amazon.IoT.Model.Tag>(this.Tag);
            }
            context.VerificationCertificate = this.VerificationCertificate;
            #if MODULAR
            if (this.VerificationCertificate == null && ParameterWasBound(nameof(this.VerificationCertificate)))
            {
                WriteWarning("You are passing $null as a value for parameter VerificationCertificate which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
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
            var request = new Amazon.IoT.Model.RegisterCACertificateRequest();
            
            if (cmdletContext.AllowAutoRegistration != null)
            {
                request.AllowAutoRegistration = cmdletContext.AllowAutoRegistration.Value;
            }
            if (cmdletContext.CaCertificate != null)
            {
                request.CaCertificate = cmdletContext.CaCertificate;
            }
            
             // populate RegistrationConfig
            var requestRegistrationConfigIsNull = true;
            request.RegistrationConfig = new Amazon.IoT.Model.RegistrationConfig();
            System.String requestRegistrationConfig_registrationConfig_RoleArn = null;
            if (cmdletContext.RegistrationConfig_RoleArn != null)
            {
                requestRegistrationConfig_registrationConfig_RoleArn = cmdletContext.RegistrationConfig_RoleArn;
            }
            if (requestRegistrationConfig_registrationConfig_RoleArn != null)
            {
                request.RegistrationConfig.RoleArn = requestRegistrationConfig_registrationConfig_RoleArn;
                requestRegistrationConfigIsNull = false;
            }
            System.String requestRegistrationConfig_registrationConfig_TemplateBody = null;
            if (cmdletContext.RegistrationConfig_TemplateBody != null)
            {
                requestRegistrationConfig_registrationConfig_TemplateBody = cmdletContext.RegistrationConfig_TemplateBody;
            }
            if (requestRegistrationConfig_registrationConfig_TemplateBody != null)
            {
                request.RegistrationConfig.TemplateBody = requestRegistrationConfig_registrationConfig_TemplateBody;
                requestRegistrationConfigIsNull = false;
            }
             // determine if request.RegistrationConfig should be set to null
            if (requestRegistrationConfigIsNull)
            {
                request.RegistrationConfig = null;
            }
            if (cmdletContext.SetAsActive != null)
            {
                request.SetAsActive = cmdletContext.SetAsActive.Value;
            }
            if (cmdletContext.Tag != null)
            {
                request.Tags = cmdletContext.Tag;
            }
            if (cmdletContext.VerificationCertificate != null)
            {
                request.VerificationCertificate = cmdletContext.VerificationCertificate;
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
        
        private Amazon.IoT.Model.RegisterCACertificateResponse CallAWSServiceOperation(IAmazonIoT client, Amazon.IoT.Model.RegisterCACertificateRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT", "RegisterCACertificate");
            try
            {
                #if DESKTOP
                return client.RegisterCACertificate(request);
                #elif CORECLR
                return client.RegisterCACertificateAsync(request).GetAwaiter().GetResult();
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
            public System.Boolean? AllowAutoRegistration { get; set; }
            public System.String CaCertificate { get; set; }
            public System.String RegistrationConfig_RoleArn { get; set; }
            public System.String RegistrationConfig_TemplateBody { get; set; }
            public System.Boolean? SetAsActive { get; set; }
            public List<Amazon.IoT.Model.Tag> Tag { get; set; }
            public System.String VerificationCertificate { get; set; }
            public System.Func<Amazon.IoT.Model.RegisterCACertificateResponse, RegisterIOTCACertificateCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response;
        }
        
    }
}
