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
using Amazon.Chime;
using Amazon.Chime.Model;

namespace Amazon.PowerShell.Cmdlets.CHM
{
    /// <summary>
    /// Starts transcription for the specified <code>meetingId</code>.
    /// </summary>
    [Cmdlet("Start", "CHMMeetingTranscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("None")]
    [AWSCmdlet("Calls the Amazon Chime StartMeetingTranscription API operation.", Operation = new[] {"StartMeetingTranscription"}, SelectReturnType = typeof(Amazon.Chime.Model.StartMeetingTranscriptionResponse))]
    [AWSCmdletOutput("None or Amazon.Chime.Model.StartMeetingTranscriptionResponse",
        "This cmdlet does not generate any output." +
        "The service response (type Amazon.Chime.Model.StartMeetingTranscriptionResponse) can be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class StartCHMMeetingTranscriptionCmdlet : AmazonChimeClientCmdlet, IExecutor
    {
        
        #region Parameter EngineTranscribeMedicalSettings_LanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code specified for the Amazon Transcribe Medical engine.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeMedicalSettings_LanguageCode")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeMedicalLanguageCode")]
        public Amazon.Chime.TranscribeMedicalLanguageCode EngineTranscribeMedicalSettings_LanguageCode { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeSettings_LanguageCode
        /// <summary>
        /// <para>
        /// <para>The language code specified for the Amazon Transcribe engine.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeSettings_LanguageCode")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeLanguageCode")]
        public Amazon.Chime.TranscribeLanguageCode EngineTranscribeSettings_LanguageCode { get; set; }
        #endregion
        
        #region Parameter MeetingId
        /// <summary>
        /// <para>
        /// <para>The unique ID of the meeting being transcribed.</para>
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
        public System.String MeetingId { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeMedicalSettings_Region
        /// <summary>
        /// <para>
        /// <para>The AWS Region passed to Amazon Transcribe Medical. If you don't specify a Region,
        /// Amazon Chime uses the meeting's Region.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeMedicalSettings_Region")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeMedicalRegion")]
        public Amazon.Chime.TranscribeMedicalRegion EngineTranscribeMedicalSettings_Region { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeSettings_Region
        /// <summary>
        /// <para>
        /// <para>The AWS Region passed to Amazon Transcribe. If you don't specify a Region, Amazon
        /// Chime uses the meeting's Region.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeSettings_Region")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeRegion")]
        public Amazon.Chime.TranscribeRegion EngineTranscribeSettings_Region { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeMedicalSettings_Specialty
        /// <summary>
        /// <para>
        /// <para>The specialty specified for the Amazon Transcribe Medical engine.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeMedicalSettings_Specialty")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeMedicalSpecialty")]
        public Amazon.Chime.TranscribeMedicalSpecialty EngineTranscribeMedicalSettings_Specialty { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeMedicalSettings_Type
        /// <summary>
        /// <para>
        /// <para>The type of transcription.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeMedicalSettings_Type")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeMedicalType")]
        public Amazon.Chime.TranscribeMedicalType EngineTranscribeMedicalSettings_Type { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeSettings_VocabularyFilterMethod
        /// <summary>
        /// <para>
        /// <para>The filtering method passed to Amazon Transcribe.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeSettings_VocabularyFilterMethod")]
        [AWSConstantClassSource("Amazon.Chime.TranscribeVocabularyFilterMethod")]
        public Amazon.Chime.TranscribeVocabularyFilterMethod EngineTranscribeSettings_VocabularyFilterMethod { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeSettings_VocabularyFilterName
        /// <summary>
        /// <para>
        /// <para>The name of the vocabulary filter passed to Amazon Transcribe.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeSettings_VocabularyFilterName")]
        public System.String EngineTranscribeSettings_VocabularyFilterName { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeMedicalSettings_VocabularyName
        /// <summary>
        /// <para>
        /// <para>The name of the vocabulary passed to Amazon Transcribe Medical.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeMedicalSettings_VocabularyName")]
        public System.String EngineTranscribeMedicalSettings_VocabularyName { get; set; }
        #endregion
        
        #region Parameter EngineTranscribeSettings_VocabularyName
        /// <summary>
        /// <para>
        /// <para>The name of the vocabulary passed to Amazon Transcribe.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("TranscriptionConfiguration_EngineTranscribeSettings_VocabularyName")]
        public System.String EngineTranscribeSettings_VocabularyName { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The cmdlet doesn't have a return value by default.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.Chime.Model.StartMeetingTranscriptionResponse).
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "*";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the MeetingId parameter.
        /// The -PassThru parameter is deprecated, use -Select '^MeetingId' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^MeetingId' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.MeetingId), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Start-CHMMeetingTranscription (StartMeetingTranscription)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.Chime.Model.StartMeetingTranscriptionResponse, StartCHMMeetingTranscriptionCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.MeetingId;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.MeetingId = this.MeetingId;
            #if MODULAR
            if (this.MeetingId == null && ParameterWasBound(nameof(this.MeetingId)))
            {
                WriteWarning("You are passing $null as a value for parameter MeetingId which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.EngineTranscribeMedicalSettings_LanguageCode = this.EngineTranscribeMedicalSettings_LanguageCode;
            context.EngineTranscribeMedicalSettings_Region = this.EngineTranscribeMedicalSettings_Region;
            context.EngineTranscribeMedicalSettings_Specialty = this.EngineTranscribeMedicalSettings_Specialty;
            context.EngineTranscribeMedicalSettings_Type = this.EngineTranscribeMedicalSettings_Type;
            context.EngineTranscribeMedicalSettings_VocabularyName = this.EngineTranscribeMedicalSettings_VocabularyName;
            context.EngineTranscribeSettings_LanguageCode = this.EngineTranscribeSettings_LanguageCode;
            context.EngineTranscribeSettings_Region = this.EngineTranscribeSettings_Region;
            context.EngineTranscribeSettings_VocabularyFilterMethod = this.EngineTranscribeSettings_VocabularyFilterMethod;
            context.EngineTranscribeSettings_VocabularyFilterName = this.EngineTranscribeSettings_VocabularyFilterName;
            context.EngineTranscribeSettings_VocabularyName = this.EngineTranscribeSettings_VocabularyName;
            
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
            var request = new Amazon.Chime.Model.StartMeetingTranscriptionRequest();
            
            if (cmdletContext.MeetingId != null)
            {
                request.MeetingId = cmdletContext.MeetingId;
            }
            
             // populate TranscriptionConfiguration
            var requestTranscriptionConfigurationIsNull = true;
            request.TranscriptionConfiguration = new Amazon.Chime.Model.TranscriptionConfiguration();
            Amazon.Chime.Model.EngineTranscribeMedicalSettings requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings = null;
            
             // populate EngineTranscribeMedicalSettings
            var requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = true;
            requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings = new Amazon.Chime.Model.EngineTranscribeMedicalSettings();
            Amazon.Chime.TranscribeMedicalLanguageCode requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_LanguageCode = null;
            if (cmdletContext.EngineTranscribeMedicalSettings_LanguageCode != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_LanguageCode = cmdletContext.EngineTranscribeMedicalSettings_LanguageCode;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_LanguageCode != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings.LanguageCode = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_LanguageCode;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = false;
            }
            Amazon.Chime.TranscribeMedicalRegion requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Region = null;
            if (cmdletContext.EngineTranscribeMedicalSettings_Region != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Region = cmdletContext.EngineTranscribeMedicalSettings_Region;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Region != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings.Region = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Region;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = false;
            }
            Amazon.Chime.TranscribeMedicalSpecialty requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Specialty = null;
            if (cmdletContext.EngineTranscribeMedicalSettings_Specialty != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Specialty = cmdletContext.EngineTranscribeMedicalSettings_Specialty;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Specialty != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings.Specialty = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Specialty;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = false;
            }
            Amazon.Chime.TranscribeMedicalType requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Type = null;
            if (cmdletContext.EngineTranscribeMedicalSettings_Type != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Type = cmdletContext.EngineTranscribeMedicalSettings_Type;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Type != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings.Type = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_Type;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = false;
            }
            System.String requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_VocabularyName = null;
            if (cmdletContext.EngineTranscribeMedicalSettings_VocabularyName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_VocabularyName = cmdletContext.EngineTranscribeMedicalSettings_VocabularyName;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_VocabularyName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings.VocabularyName = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings_engineTranscribeMedicalSettings_VocabularyName;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull = false;
            }
             // determine if requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings should be set to null
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettingsIsNull)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings = null;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings != null)
            {
                request.TranscriptionConfiguration.EngineTranscribeMedicalSettings = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeMedicalSettings;
                requestTranscriptionConfigurationIsNull = false;
            }
            Amazon.Chime.Model.EngineTranscribeSettings requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings = null;
            
             // populate EngineTranscribeSettings
            var requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = true;
            requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings = new Amazon.Chime.Model.EngineTranscribeSettings();
            Amazon.Chime.TranscribeLanguageCode requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_LanguageCode = null;
            if (cmdletContext.EngineTranscribeSettings_LanguageCode != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_LanguageCode = cmdletContext.EngineTranscribeSettings_LanguageCode;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_LanguageCode != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings.LanguageCode = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_LanguageCode;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = false;
            }
            Amazon.Chime.TranscribeRegion requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_Region = null;
            if (cmdletContext.EngineTranscribeSettings_Region != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_Region = cmdletContext.EngineTranscribeSettings_Region;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_Region != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings.Region = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_Region;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = false;
            }
            Amazon.Chime.TranscribeVocabularyFilterMethod requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterMethod = null;
            if (cmdletContext.EngineTranscribeSettings_VocabularyFilterMethod != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterMethod = cmdletContext.EngineTranscribeSettings_VocabularyFilterMethod;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterMethod != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings.VocabularyFilterMethod = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterMethod;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = false;
            }
            System.String requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterName = null;
            if (cmdletContext.EngineTranscribeSettings_VocabularyFilterName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterName = cmdletContext.EngineTranscribeSettings_VocabularyFilterName;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings.VocabularyFilterName = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyFilterName;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = false;
            }
            System.String requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyName = null;
            if (cmdletContext.EngineTranscribeSettings_VocabularyName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyName = cmdletContext.EngineTranscribeSettings_VocabularyName;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyName != null)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings.VocabularyName = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings_engineTranscribeSettings_VocabularyName;
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull = false;
            }
             // determine if requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings should be set to null
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettingsIsNull)
            {
                requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings = null;
            }
            if (requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings != null)
            {
                request.TranscriptionConfiguration.EngineTranscribeSettings = requestTranscriptionConfiguration_transcriptionConfiguration_EngineTranscribeSettings;
                requestTranscriptionConfigurationIsNull = false;
            }
             // determine if request.TranscriptionConfiguration should be set to null
            if (requestTranscriptionConfigurationIsNull)
            {
                request.TranscriptionConfiguration = null;
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
        
        private Amazon.Chime.Model.StartMeetingTranscriptionResponse CallAWSServiceOperation(IAmazonChime client, Amazon.Chime.Model.StartMeetingTranscriptionRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "Amazon Chime", "StartMeetingTranscription");
            try
            {
                #if DESKTOP
                return client.StartMeetingTranscription(request);
                #elif CORECLR
                return client.StartMeetingTranscriptionAsync(request).GetAwaiter().GetResult();
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
            public System.String MeetingId { get; set; }
            public Amazon.Chime.TranscribeMedicalLanguageCode EngineTranscribeMedicalSettings_LanguageCode { get; set; }
            public Amazon.Chime.TranscribeMedicalRegion EngineTranscribeMedicalSettings_Region { get; set; }
            public Amazon.Chime.TranscribeMedicalSpecialty EngineTranscribeMedicalSettings_Specialty { get; set; }
            public Amazon.Chime.TranscribeMedicalType EngineTranscribeMedicalSettings_Type { get; set; }
            public System.String EngineTranscribeMedicalSettings_VocabularyName { get; set; }
            public Amazon.Chime.TranscribeLanguageCode EngineTranscribeSettings_LanguageCode { get; set; }
            public Amazon.Chime.TranscribeRegion EngineTranscribeSettings_Region { get; set; }
            public Amazon.Chime.TranscribeVocabularyFilterMethod EngineTranscribeSettings_VocabularyFilterMethod { get; set; }
            public System.String EngineTranscribeSettings_VocabularyFilterName { get; set; }
            public System.String EngineTranscribeSettings_VocabularyName { get; set; }
            public System.Func<Amazon.Chime.Model.StartMeetingTranscriptionResponse, StartCHMMeetingTranscriptionCmdlet, object> Select { get; set; } =
                (response, cmdlet) => null;
        }
        
    }
}
