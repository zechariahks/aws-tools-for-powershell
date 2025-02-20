# Auto-generated argument completers for parameters of SDK ConstantClass-derived type used in cmdlets.
# Do not modify this file; it may be overwritten during version upgrades.

$psMajorVersion = $PSVersionTable.PSVersion.Major
if ($psMajorVersion -eq 2) 
{ 
	Write-Verbose "Dynamic argument completion not supported in PowerShell version 2; skipping load."
	return 
}

# PowerShell's native Register-ArgumentCompleter cmdlet is available on v5.0 or higher. For lower
# version, we can use the version in the TabExpansion++ module if installed.
$registrationCmdletAvailable = ($psMajorVersion -ge 5) -Or !((Get-Command Register-ArgumentCompleter -ea Ignore) -eq $null)

# internal function to perform the registration using either cmdlet or manipulation
# of the options table
function _awsArgumentCompleterRegistration()
{
    param
    (
        [scriptblock]$scriptBlock,
        [hashtable]$param2CmdletsMap
    )

    if ($registrationCmdletAvailable)
    {
        foreach ($paramName in $param2CmdletsMap.Keys)
        {
             $args = @{
                "ScriptBlock" = $scriptBlock
                "Parameter" = $paramName
            }

            $cmdletNames = $param2CmdletsMap[$paramName]
            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                $args["Command"] = $cmdletNames
            }

            Register-ArgumentCompleter @args
        }
    }
    else
    {
        if (-not $global:options) { $global:options = @{ CustomArgumentCompleters = @{ }; NativeArgumentCompleters = @{ } } }

        foreach ($paramName in $param2CmdletsMap.Keys)
        {
            $cmdletNames = $param2CmdletsMap[$paramName]

            if ($cmdletNames -And $cmdletNames.Length -gt 0)
            {
                foreach ($cn in $cmdletNames)
                {
                    $fqn =  [string]::Concat($cn, ":", $paramName)
                    $global:options['CustomArgumentCompleters'][$fqn] = $scriptBlock
                }
            }
            else
            {
                $global:options['CustomArgumentCompleters'][$paramName] = $scriptBlock
            }
        }

        $function:tabexpansion2 = $function:tabexpansion2 -replace 'End\r\n{', 'End { if ($null -ne $options) { $options += $global:options} else {$options = $global:options}'
    }
}

# To allow for same-name parameters of different ConstantClass-derived types 
# each completer function checks on command name concatenated with parameter name.
# Additionally, the standard code pattern for completers is to pipe through 
# sort-object after filtering against $wordToComplete but we omit this as our members 
# are already sorted.

# Argument completions for service Amazon Connect Service


$CONN_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.Connect.AgentStatusState
        {
            ($_ -eq "New-CONNAgentStatus/State") -Or
            ($_ -eq "Update-CONNAgentStatus/State")
        }
        {
            $v = "DISABLED","ENABLED"
            break
        }

        # Amazon.Connect.ContactFlowType
        "New-CONNContactFlow/Type"
        {
            $v = "AGENT_HOLD","AGENT_TRANSFER","AGENT_WHISPER","CONTACT_FLOW","CUSTOMER_HOLD","CUSTOMER_QUEUE","CUSTOMER_WHISPER","OUTBOUND_WHISPER","QUEUE_TRANSFER"
            break
        }

        # Amazon.Connect.DirectoryType
        "New-CONNInstance/IdentityManagementType"
        {
            $v = "CONNECT_MANAGED","EXISTING_DIRECTORY","SAML"
            break
        }

        # Amazon.Connect.EncryptionType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfig_KinesisVideoStreamConfig_EncryptionConfig_EncryptionType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfig_KinesisVideoStreamConfig_EncryptionConfig_EncryptionType") -Or
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfig_S3Config_EncryptionConfig_EncryptionType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfig_S3Config_EncryptionConfig_EncryptionType")
        }
        {
            $v = "KMS"
            break
        }

        # Amazon.Connect.InstanceAttributeType
        {
            ($_ -eq "Get-CONNInstanceAttribute/AttributeType") -Or
            ($_ -eq "Update-CONNInstanceAttribute/AttributeType")
        }
        {
            $v = "AUTO_RESOLVE_BEST_VOICES","CONTACTFLOW_LOGS","CONTACT_LENS","EARLY_MEDIA","INBOUND_CALLS","OUTBOUND_CALLS","USE_CUSTOM_TTS_VOICES"
            break
        }

        # Amazon.Connect.InstanceStorageResourceType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Get-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Get-CONNInstanceStorageConfigList/ResourceType") -Or
            ($_ -eq "Remove-CONNInstanceStorageConfig/ResourceType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/ResourceType")
        }
        {
            $v = "AGENT_EVENTS","CALL_RECORDINGS","CHAT_TRANSCRIPTS","CONTACT_TRACE_RECORDS","MEDIA_STREAMS","SCHEDULED_REPORTS"
            break
        }

        # Amazon.Connect.IntegrationType
        {
            ($_ -eq "Get-CONNIntegrationAssociationList/IntegrationType") -Or
            ($_ -eq "New-CONNIntegrationAssociation/IntegrationType")
        }
        {
            $v = "EVENT","PINPOINT_APP","VOICE_ID","WISDOM_ASSISTANT","WISDOM_KNOWLEDGE_BASE"
            break
        }

        # Amazon.Connect.LexVersion
        "Get-CONNBotList/LexVersion"
        {
            $v = "V1","V2"
            break
        }

        # Amazon.Connect.QueueStatus
        "Update-CONNQueueStatus/Status"
        {
            $v = "DISABLED","ENABLED"
            break
        }

        # Amazon.Connect.QuickConnectType
        {
            ($_ -eq "New-CONNQuickConnect/QuickConnectConfig_QuickConnectType") -Or
            ($_ -eq "Update-CONNQuickConnectConfig/QuickConnectConfig_QuickConnectType")
        }
        {
            $v = "PHONE_NUMBER","QUEUE","USER"
            break
        }

        # Amazon.Connect.SourceType
        "New-CONNIntegrationAssociation/SourceType"
        {
            $v = "SALESFORCE","ZENDESK"
            break
        }

        # Amazon.Connect.StorageType
        {
            ($_ -eq "Add-CONNInstanceStorageConfig/StorageConfig_StorageType") -Or
            ($_ -eq "Update-CONNInstanceStorageConfig/StorageConfig_StorageType")
        }
        {
            $v = "KINESIS_FIREHOSE","KINESIS_STREAM","KINESIS_VIDEO_STREAM","S3"
            break
        }

        # Amazon.Connect.TrafficType
        "Start-CONNOutboundVoiceContact/TrafficType"
        {
            $v = "CAMPAIGN","GENERAL"
            break
        }

        # Amazon.Connect.UseCaseType
        "New-CONNUseCase/UseCaseType"
        {
            $v = "CONNECT_CAMPAIGNS","RULES_EVALUATION"
            break
        }

        # Amazon.Connect.VoiceRecordingTrack
        "Start-CONNContactRecording/VoiceRecordingConfiguration_VoiceRecordingTrack"
        {
            $v = "ALL","FROM_AGENT","TO_AGENT"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$CONN_map = @{
    "AttributeType"=@("Get-CONNInstanceAttribute","Update-CONNInstanceAttribute")
    "IdentityManagementType"=@("New-CONNInstance")
    "IntegrationType"=@("Get-CONNIntegrationAssociationList","New-CONNIntegrationAssociation")
    "LexVersion"=@("Get-CONNBotList")
    "QuickConnectConfig_QuickConnectType"=@("New-CONNQuickConnect","Update-CONNQuickConnectConfig")
    "ResourceType"=@("Add-CONNInstanceStorageConfig","Get-CONNInstanceStorageConfig","Get-CONNInstanceStorageConfigList","Remove-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "SourceType"=@("New-CONNIntegrationAssociation")
    "State"=@("New-CONNAgentStatus","Update-CONNAgentStatus")
    "Status"=@("Update-CONNQueueStatus")
    "StorageConfig_KinesisVideoStreamConfig_EncryptionConfig_EncryptionType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "StorageConfig_S3Config_EncryptionConfig_EncryptionType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "StorageConfig_StorageType"=@("Add-CONNInstanceStorageConfig","Update-CONNInstanceStorageConfig")
    "TrafficType"=@("Start-CONNOutboundVoiceContact")
    "Type"=@("New-CONNContactFlow")
    "UseCaseType"=@("New-CONNUseCase")
    "VoiceRecordingConfiguration_VoiceRecordingTrack"=@("Start-CONNContactRecording")
}

_awsArgumentCompleterRegistration $CONN_Completers $CONN_map

$CONN_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.CONN.$($commandName.Replace('-', ''))Cmdlet]"
    if (-not $cmdletType) {
        return
    }
    $awsCmdletAttribute = $cmdletType.GetCustomAttributes([Amazon.PowerShell.Common.AWSCmdletAttribute], $false)
    if (-not $awsCmdletAttribute) {
        return
    }
    $type = $awsCmdletAttribute.SelectReturnType
    if (-not $type) {
        return
    }

    $splitSelect = $wordToComplete -Split '\.'
    $splitSelect | Select-Object -First ($splitSelect.Length - 1) | ForEach-Object {
        $propertyName = $_
        $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')) | Where-Object { $_.Name -ieq $propertyName }
        if ($properties.Length -ne 1) {
            break
        }
        $type = $properties.PropertyType
        $prefix += "$($properties.Name)."

        $asEnumerableType = $type.GetInterface('System.Collections.Generic.IEnumerable`1')
        if ($asEnumerableType -and $type -ne [System.String]) {
            $type =  $asEnumerableType.GetGenericArguments()[0]
        }
    }

    $v = @( '*' )
    $properties = $type.GetProperties(('Instance', 'Public', 'DeclaredOnly')).Name | Sort-Object
    if ($properties) {
        $v += ($properties | ForEach-Object { $prefix + $_ })
    }
    $parameters = $cmdletType.GetProperties(('Instance', 'Public')) | Where-Object { $_.GetCustomAttributes([System.Management.Automation.ParameterAttribute], $true) } | Select-Object -ExpandProperty Name | Sort-Object
    if ($parameters) {
        $v += ($parameters | ForEach-Object { "^$_" })
    }

    $v |
        Where-Object { $_ -match "^$([System.Text.RegularExpressions.Regex]::Escape($wordToComplete)).*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$CONN_SelectMap = @{
    "Select"=@("Add-CONNApprovedOrigin",
               "Add-CONNBot",
               "Add-CONNInstanceStorageConfig",
               "Add-CONNLambdaFunction",
               "Add-CONNLexBot",
               "Add-CONNQueueQuickConnect",
               "Join-CONNRoutingProfileQueue",
               "Add-CONNSecurityKey",
               "New-CONNAgentStatus",
               "New-CONNContactFlow",
               "New-CONNHoursOfOperation",
               "New-CONNInstance",
               "New-CONNIntegrationAssociation",
               "New-CONNQueue",
               "New-CONNQuickConnect",
               "New-CONNRoutingProfile",
               "New-CONNUseCase",
               "New-CONNUser",
               "New-CONNUserHierarchyGroup",
               "Remove-CONNHoursOfOperation",
               "Remove-CONNInstance",
               "Remove-CONNIntegrationAssociation",
               "Remove-CONNQuickConnect",
               "Remove-CONNUseCase",
               "Remove-CONNUser",
               "Remove-CONNUserHierarchyGroup",
               "Get-CONNAgentStatus",
               "Get-CONNContactFlow",
               "Get-CONNHoursOfOperation",
               "Get-CONNInstance",
               "Get-CONNInstanceAttribute",
               "Get-CONNInstanceStorageConfig",
               "Get-CONNQueue",
               "Get-CONNQuickConnect",
               "Get-CONNRoutingProfile",
               "Get-CONNUser",
               "Get-CONNUserHierarchyGroup",
               "Get-CONNUserHierarchyStructure",
               "Remove-CONNApprovedOrigin",
               "Remove-CONNBot",
               "Remove-CONNInstanceStorageConfig",
               "Remove-CONNLambdaFunction",
               "Remove-CONNLexBot",
               "Remove-CONNQueueQuickConnect",
               "Disconnect-CONNRoutingProfileQueue",
               "Remove-CONNSecurityKey",
               "Get-CONNContactAttribute",
               "Get-CONNCurrentMetricData",
               "Get-CONNFederationToken",
               "Get-CONNMetricData",
               "Get-CONNAgentStatusList",
               "Get-CONNApprovedOriginList",
               "Get-CONNBotList",
               "Get-CONNContactFlowList",
               "Get-CONNHoursOfOperationList",
               "Get-CONNInstanceAttributeList",
               "Get-CONNInstanceList",
               "Get-CONNInstanceStorageConfigList",
               "Get-CONNIntegrationAssociationList",
               "Get-CONNLambdaFunctionList",
               "Get-CONNLexBotList",
               "Get-CONNPhoneNumberList",
               "Get-CONNPromptList",
               "Get-CONNQueueQuickConnectList",
               "Get-CONNQueueList",
               "Get-CONNQuickConnectList",
               "Get-CONNRoutingProfileQueueList",
               "Get-CONNRoutingProfileList",
               "Get-CONNSecurityKeyList",
               "Get-CONNSecurityProfileList",
               "Get-CONNResourceTag",
               "Get-CONNUseCaseList",
               "Get-CONNUserHierarchyGroupList",
               "Get-CONNUserList",
               "Resume-CONNContactRecording",
               "Start-CONNChatContact",
               "Start-CONNContactRecording",
               "Start-CONNOutboundVoiceContact",
               "Start-CONNTaskContact",
               "Stop-CONNContact",
               "Stop-CONNContactRecording",
               "Suspend-CONNContactRecording",
               "Add-CONNResourceTag",
               "Remove-CONNResourceTag",
               "Update-CONNAgentStatus",
               "Update-CONNContactAttribute",
               "Update-CONNContactFlowContent",
               "Update-CONNContactFlowName",
               "Update-CONNHoursOfOperation",
               "Update-CONNInstanceAttribute",
               "Update-CONNInstanceStorageConfig",
               "Update-CONNQueueHoursOfOperation",
               "Update-CONNQueueMaxContact",
               "Update-CONNQueueName",
               "Update-CONNQueueOutboundCallerConfig",
               "Update-CONNQueueStatus",
               "Update-CONNQuickConnectConfig",
               "Update-CONNQuickConnectName",
               "Update-CONNRoutingProfileConcurrency",
               "Update-CONNRoutingProfileDefaultOutboundQueue",
               "Update-CONNRoutingProfileName",
               "Update-CONNRoutingProfileQueue",
               "Update-CONNUserHierarchy",
               "Update-CONNUserHierarchyGroupName",
               "Update-CONNUserHierarchyStructure",
               "Update-CONNUserIdentityInfo",
               "Update-CONNUserPhoneConfig",
               "Update-CONNUserRoutingProfile",
               "Update-CONNUserSecurityProfile")
}

_awsArgumentCompleterRegistration $CONN_SelectCompleters $CONN_SelectMap

