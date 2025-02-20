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
using Amazon.IoTWireless;
using Amazon.IoTWireless.Model;

namespace Amazon.PowerShell.Cmdlets.IOTW
{
    /// <summary>
    /// Sends a decrypted application data frame to a device.
    /// </summary>
    [Cmdlet("Send", "IOTWDataToWirelessDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType("System.String")]
    [AWSCmdlet("Calls the AWS IoT Wireless SendDataToWirelessDevice API operation.", Operation = new[] {"SendDataToWirelessDevice"}, SelectReturnType = typeof(Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse))]
    [AWSCmdletOutput("System.String or Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse",
        "This cmdlet returns a System.String object.",
        "The service call response (type Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse) can also be referenced from properties attached to the cmdlet entry in the $AWSHistory stack."
    )]
    public partial class SendIOTWDataToWirelessDeviceCmdlet : AmazonIoTWirelessClientCmdlet, IExecutor
    {
        
        #region Parameter LoRaWAN_FPort
        /// <summary>
        /// <para>
        /// <para>The Fport value.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WirelessMetadata_LoRaWAN_FPort")]
        public System.Int32? LoRaWAN_FPort { get; set; }
        #endregion
        
        #region Parameter Id
        /// <summary>
        /// <para>
        /// <para>The ID of the wireless device to receive the data.</para>
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
        public System.String Id { get; set; }
        #endregion
        
        #region Parameter Sidewalk_MessageType
        /// <summary>
        /// <para>
        /// The service has not provided documentation for this parameter; please refer to the service's API reference documentation for the latest available information.
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WirelessMetadata_Sidewalk_MessageType")]
        [AWSConstantClassSource("Amazon.IoTWireless.MessageType")]
        public Amazon.IoTWireless.MessageType Sidewalk_MessageType { get; set; }
        #endregion
        
        #region Parameter PayloadData
        /// <summary>
        /// <para>
        /// <para>The binary to be sent to the end device, encoded in base64.</para>
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
        public System.String PayloadData { get; set; }
        #endregion
        
        #region Parameter Sidewalk_Seq
        /// <summary>
        /// <para>
        /// <para>The sequence number.</para>
        /// </para>
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        [Alias("WirelessMetadata_Sidewalk_Seq")]
        public System.Int32? Sidewalk_Seq { get; set; }
        #endregion
        
        #region Parameter TransmitMode
        /// <summary>
        /// <para>
        /// <para>The transmit mode to use to send data to the wireless device. Can be: <code>0</code>
        /// for UM (unacknowledge mode) or <code>1</code> for AM (acknowledge mode).</para>
        /// </para>
        /// </summary>
        #if !MODULAR
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        #else
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        [System.Management.Automation.AllowNull]
        #endif
        [Amazon.PowerShell.Common.AWSRequiredParameter]
        public System.Int32? TransmitMode { get; set; }
        #endregion
        
        #region Parameter Select
        /// <summary>
        /// Use the -Select parameter to control the cmdlet output. The default value is 'MessageId'.
        /// Specifying -Select '*' will result in the cmdlet returning the whole service response (Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse).
        /// Specifying the name of a property of type Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse will result in that property being returned.
        /// Specifying -Select '^ParameterName' will result in the cmdlet returning the selected cmdlet parameter value.
        /// </summary>
        [System.Management.Automation.Parameter(ValueFromPipelineByPropertyName = true)]
        public string Select { get; set; } = "MessageId";
        #endregion
        
        #region Parameter PassThru
        /// <summary>
        /// Changes the cmdlet behavior to return the value passed to the Id parameter.
        /// The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.
        /// </summary>
        [System.Obsolete("The -PassThru parameter is deprecated, use -Select '^Id' instead. This parameter will be removed in a future version.")]
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
            
            var resourceIdentifiersText = FormatParameterValuesForConfirmationMsg(nameof(this.Id), MyInvocation.BoundParameters);
            if (!ConfirmShouldProceed(this.Force.IsPresent, resourceIdentifiersText, "Send-IOTWDataToWirelessDevice (SendDataToWirelessDevice)"))
            {
                return;
            }
            
            var context = new CmdletContext();
            
            // allow for manipulation of parameters prior to loading into context
            PreExecutionContextLoad(context);
            
            #pragma warning disable CS0618, CS0612 //A class member was marked with the Obsolete attribute
            if (ParameterWasBound(nameof(this.Select)))
            {
                context.Select = CreateSelectDelegate<Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse, SendIOTWDataToWirelessDeviceCmdlet>(Select) ??
                    throw new System.ArgumentException("Invalid value for -Select parameter.", nameof(this.Select));
                if (this.PassThru.IsPresent)
                {
                    throw new System.ArgumentException("-PassThru cannot be used when -Select is specified.", nameof(this.Select));
                }
            }
            else if (this.PassThru.IsPresent)
            {
                context.Select = (response, cmdlet) => this.Id;
            }
            #pragma warning restore CS0618, CS0612 //A class member was marked with the Obsolete attribute
            context.Id = this.Id;
            #if MODULAR
            if (this.Id == null && ParameterWasBound(nameof(this.Id)))
            {
                WriteWarning("You are passing $null as a value for parameter Id which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.PayloadData = this.PayloadData;
            #if MODULAR
            if (this.PayloadData == null && ParameterWasBound(nameof(this.PayloadData)))
            {
                WriteWarning("You are passing $null as a value for parameter PayloadData which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.TransmitMode = this.TransmitMode;
            #if MODULAR
            if (this.TransmitMode == null && ParameterWasBound(nameof(this.TransmitMode)))
            {
                WriteWarning("You are passing $null as a value for parameter TransmitMode which is marked as required. In case you believe this parameter was incorrectly marked as required, report this by opening an issue at https://github.com/aws/aws-tools-for-powershell/issues.");
            }
            #endif
            context.LoRaWAN_FPort = this.LoRaWAN_FPort;
            context.Sidewalk_MessageType = this.Sidewalk_MessageType;
            context.Sidewalk_Seq = this.Sidewalk_Seq;
            
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
            var request = new Amazon.IoTWireless.Model.SendDataToWirelessDeviceRequest();
            
            if (cmdletContext.Id != null)
            {
                request.Id = cmdletContext.Id;
            }
            if (cmdletContext.PayloadData != null)
            {
                request.PayloadData = cmdletContext.PayloadData;
            }
            if (cmdletContext.TransmitMode != null)
            {
                request.TransmitMode = cmdletContext.TransmitMode.Value;
            }
            
             // populate WirelessMetadata
            var requestWirelessMetadataIsNull = true;
            request.WirelessMetadata = new Amazon.IoTWireless.Model.WirelessMetadata();
            Amazon.IoTWireless.Model.LoRaWANSendDataToDevice requestWirelessMetadata_wirelessMetadata_LoRaWAN = null;
            
             // populate LoRaWAN
            var requestWirelessMetadata_wirelessMetadata_LoRaWANIsNull = true;
            requestWirelessMetadata_wirelessMetadata_LoRaWAN = new Amazon.IoTWireless.Model.LoRaWANSendDataToDevice();
            System.Int32? requestWirelessMetadata_wirelessMetadata_LoRaWAN_loRaWAN_FPort = null;
            if (cmdletContext.LoRaWAN_FPort != null)
            {
                requestWirelessMetadata_wirelessMetadata_LoRaWAN_loRaWAN_FPort = cmdletContext.LoRaWAN_FPort.Value;
            }
            if (requestWirelessMetadata_wirelessMetadata_LoRaWAN_loRaWAN_FPort != null)
            {
                requestWirelessMetadata_wirelessMetadata_LoRaWAN.FPort = requestWirelessMetadata_wirelessMetadata_LoRaWAN_loRaWAN_FPort.Value;
                requestWirelessMetadata_wirelessMetadata_LoRaWANIsNull = false;
            }
             // determine if requestWirelessMetadata_wirelessMetadata_LoRaWAN should be set to null
            if (requestWirelessMetadata_wirelessMetadata_LoRaWANIsNull)
            {
                requestWirelessMetadata_wirelessMetadata_LoRaWAN = null;
            }
            if (requestWirelessMetadata_wirelessMetadata_LoRaWAN != null)
            {
                request.WirelessMetadata.LoRaWAN = requestWirelessMetadata_wirelessMetadata_LoRaWAN;
                requestWirelessMetadataIsNull = false;
            }
            Amazon.IoTWireless.Model.SidewalkSendDataToDevice requestWirelessMetadata_wirelessMetadata_Sidewalk = null;
            
             // populate Sidewalk
            var requestWirelessMetadata_wirelessMetadata_SidewalkIsNull = true;
            requestWirelessMetadata_wirelessMetadata_Sidewalk = new Amazon.IoTWireless.Model.SidewalkSendDataToDevice();
            Amazon.IoTWireless.MessageType requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_MessageType = null;
            if (cmdletContext.Sidewalk_MessageType != null)
            {
                requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_MessageType = cmdletContext.Sidewalk_MessageType;
            }
            if (requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_MessageType != null)
            {
                requestWirelessMetadata_wirelessMetadata_Sidewalk.MessageType = requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_MessageType;
                requestWirelessMetadata_wirelessMetadata_SidewalkIsNull = false;
            }
            System.Int32? requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_Seq = null;
            if (cmdletContext.Sidewalk_Seq != null)
            {
                requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_Seq = cmdletContext.Sidewalk_Seq.Value;
            }
            if (requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_Seq != null)
            {
                requestWirelessMetadata_wirelessMetadata_Sidewalk.Seq = requestWirelessMetadata_wirelessMetadata_Sidewalk_sidewalk_Seq.Value;
                requestWirelessMetadata_wirelessMetadata_SidewalkIsNull = false;
            }
             // determine if requestWirelessMetadata_wirelessMetadata_Sidewalk should be set to null
            if (requestWirelessMetadata_wirelessMetadata_SidewalkIsNull)
            {
                requestWirelessMetadata_wirelessMetadata_Sidewalk = null;
            }
            if (requestWirelessMetadata_wirelessMetadata_Sidewalk != null)
            {
                request.WirelessMetadata.Sidewalk = requestWirelessMetadata_wirelessMetadata_Sidewalk;
                requestWirelessMetadataIsNull = false;
            }
             // determine if request.WirelessMetadata should be set to null
            if (requestWirelessMetadataIsNull)
            {
                request.WirelessMetadata = null;
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
        
        private Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse CallAWSServiceOperation(IAmazonIoTWireless client, Amazon.IoTWireless.Model.SendDataToWirelessDeviceRequest request)
        {
            Utils.Common.WriteVerboseEndpointMessage(this, client.Config, "AWS IoT Wireless", "SendDataToWirelessDevice");
            try
            {
                #if DESKTOP
                return client.SendDataToWirelessDevice(request);
                #elif CORECLR
                return client.SendDataToWirelessDeviceAsync(request).GetAwaiter().GetResult();
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
            public System.String Id { get; set; }
            public System.String PayloadData { get; set; }
            public System.Int32? TransmitMode { get; set; }
            public System.Int32? LoRaWAN_FPort { get; set; }
            public Amazon.IoTWireless.MessageType Sidewalk_MessageType { get; set; }
            public System.Int32? Sidewalk_Seq { get; set; }
            public System.Func<Amazon.IoTWireless.Model.SendDataToWirelessDeviceResponse, SendIOTWDataToWirelessDeviceCmdlet, object> Select { get; set; } =
                (response, cmdlet) => response.MessageId;
        }
        
    }
}
