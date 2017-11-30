<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Customer.Web.Api.Azure" generation="1" functional="0" release="0" Id="dbe85350-21c4-4106-a802-6436bde1f112" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Customer.Web.Api.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Customer.Web.Api:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/LB:Customer.Web.Api:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Customer.Web.Api:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/MapCustomer.Web.Api:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="Customer.Web.ApiInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/MapCustomer.Web.ApiInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Customer.Web.Api:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.Api/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapCustomer.Web.Api:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.Api/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapCustomer.Web.ApiInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.ApiInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Customer.Web.Api" generation="1" functional="0" release="0" software="D:\Hackathon\hackathon\AutomationTestCoverageTool\Customer.Web.Api.Azure\csx\Debug\roles\Customer.Web.Api" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Customer.Web.Api&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Customer.Web.Api&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.ApiInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.ApiUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.ApiFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="Customer.Web.ApiUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="Customer.Web.ApiFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="Customer.Web.ApiInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="8833a866-f32d-48db-a14e-5a6998c109fd" ref="Microsoft.RedDog.Contract\ServiceContract\Customer.Web.Api.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="a39e68e9-4f6d-40dc-bf61-0acaf9a1c137" ref="Microsoft.RedDog.Contract\Interface\Customer.Web.Api:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Customer.Web.Api.Azure/Customer.Web.Api.AzureGroup/Customer.Web.Api:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>