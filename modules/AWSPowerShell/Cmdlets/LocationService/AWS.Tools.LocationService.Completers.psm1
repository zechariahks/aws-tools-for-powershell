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

# Argument completions for service Amazon Location Service


$LOC_Completers = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    switch ($("$commandName/$parameterName"))
    {
        # Amazon.LocationService.DimensionUnit
        "Get-LOCRoute/TruckModeOptions_Dimensions_Unit"
        {
            $v = "Feet","Meters"
            break
        }

        # Amazon.LocationService.DistanceUnit
        "Get-LOCRoute/DistanceUnit"
        {
            $v = "Kilometers","Miles"
            break
        }

        # Amazon.LocationService.IntendedUse
        {
            ($_ -eq "Edit-LOCPlaceIndex/DataSourceConfiguration_IntendedUse") -Or
            ($_ -eq "New-LOCPlaceIndex/DataSourceConfiguration_IntendedUse")
        }
        {
            $v = "SingleUse","Storage"
            break
        }

        # Amazon.LocationService.PricingPlan
        {
            ($_ -eq "Edit-LOCGeofenceCollection/PricingPlan") -Or
            ($_ -eq "Edit-LOCMap/PricingPlan") -Or
            ($_ -eq "Edit-LOCPlaceIndex/PricingPlan") -Or
            ($_ -eq "Edit-LOCRouteCalculator/PricingPlan") -Or
            ($_ -eq "Edit-LOCTracker/PricingPlan") -Or
            ($_ -eq "New-LOCGeofenceCollection/PricingPlan") -Or
            ($_ -eq "New-LOCMap/PricingPlan") -Or
            ($_ -eq "New-LOCPlaceIndex/PricingPlan") -Or
            ($_ -eq "New-LOCRouteCalculator/PricingPlan") -Or
            ($_ -eq "New-LOCTracker/PricingPlan")
        }
        {
            $v = "MobileAssetManagement","MobileAssetTracking","RequestBasedUsage"
            break
        }

        # Amazon.LocationService.TravelMode
        "Get-LOCRoute/TravelMode"
        {
            $v = "Car","Truck","Walking"
            break
        }

        # Amazon.LocationService.VehicleWeightUnit
        "Get-LOCRoute/TruckModeOptions_Weight_Unit"
        {
            $v = "Kilograms","Pounds"
            break
        }


    }

    $v |
        Where-Object { $_ -like "$wordToComplete*" } |
        ForEach-Object { New-Object System.Management.Automation.CompletionResult $_, $_, 'ParameterValue', $_ }
}

$LOC_map = @{
    "DataSourceConfiguration_IntendedUse"=@("Edit-LOCPlaceIndex","New-LOCPlaceIndex")
    "DistanceUnit"=@("Get-LOCRoute")
    "PricingPlan"=@("Edit-LOCGeofenceCollection","Edit-LOCMap","Edit-LOCPlaceIndex","Edit-LOCRouteCalculator","Edit-LOCTracker","New-LOCGeofenceCollection","New-LOCMap","New-LOCPlaceIndex","New-LOCRouteCalculator","New-LOCTracker")
    "TravelMode"=@("Get-LOCRoute")
    "TruckModeOptions_Dimensions_Unit"=@("Get-LOCRoute")
    "TruckModeOptions_Weight_Unit"=@("Get-LOCRoute")
}

_awsArgumentCompleterRegistration $LOC_Completers $LOC_map

$LOC_SelectCompleters = {
    param($commandName, $parameterName, $wordToComplete, $commandAst, $fakeBoundParameter)

    $cmdletType = Invoke-Expression "[Amazon.PowerShell.Cmdlets.LOC.$($commandName.Replace('-', ''))Cmdlet]"
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

$LOC_SelectMap = @{
    "Select"=@("Register-LOCTrackerConsumer",
               "Remove-LOCDevicePositionHistoryBatch",
               "Remove-LOCGeofenceBatch",
               "Submit-LOCGeofenceEvaluationBatch",
               "Get-LOCDevicePositionBatch",
               "Set-LOCGeofenceBatch",
               "Set-LOCDevicePositionBatch",
               "Get-LOCRoute",
               "New-LOCGeofenceCollection",
               "New-LOCMap",
               "New-LOCPlaceIndex",
               "New-LOCRouteCalculator",
               "New-LOCTracker",
               "Remove-LOCGeofenceCollection",
               "Remove-LOCMap",
               "Remove-LOCPlaceIndex",
               "Remove-LOCRouteCalculator",
               "Remove-LOCTracker",
               "Get-LOCGeofenceCollection",
               "Get-LOCMap",
               "Get-LOCPlaceIndex",
               "Get-LOCRouteCalculator",
               "Get-LOCTracker",
               "Unregister-LOCTrackerConsumer",
               "Get-LOCDevicePosition",
               "Get-LOCDevicePositionHistory",
               "Get-LOCGeofence",
               "Get-LOCMapGlyph",
               "Get-LOCMapSprite",
               "Get-LOCMapStyleDescriptor",
               "Get-LOCMapTile",
               "Get-LOCDevicePositionList",
               "Get-LOCGeofenceCollectionList",
               "Get-LOCGeofenceList",
               "Get-LOCMapList",
               "Get-LOCPlaceIndexList",
               "Get-LOCRouteCalculatorList",
               "Get-LOCResourceTagSet",
               "Get-LOCTrackerConsumerList",
               "Get-LOCTrackerList",
               "Set-LOCGeofence",
               "Search-LOCPlaceIndexForPosition",
               "Search-LOCPlaceIndexForText",
               "Add-LOCResourceTagSet",
               "Remove-LOCResourceTagSet",
               "Edit-LOCGeofenceCollection",
               "Edit-LOCMap",
               "Edit-LOCPlaceIndex",
               "Edit-LOCRouteCalculator",
               "Edit-LOCTracker")
}

_awsArgumentCompleterRegistration $LOC_SelectCompleters $LOC_SelectMap

