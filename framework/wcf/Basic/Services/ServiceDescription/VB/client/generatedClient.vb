'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



Namespace Microsoft.ServiceModel.Samples
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://Microsoft.ServiceModel.Samples", ConfigurationName:="Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator")>  _
    Public Interface IServiceDescriptionCalculator
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/Add", ReplyAction:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/AddResponse")>  _
        Function Add(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/Subtract", ReplyAction:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/SubtractRespo"& _ 
            "nse")>  _
        Function Subtract(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/Multiply", ReplyAction:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/MultiplyRespo"& _ 
            "nse")>  _
        Function Multiply(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/Divide", ReplyAction:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/DivideRespons"& _ 
            "e")>  _
        Function Divide(ByVal n1 As Integer, ByVal n2 As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/GetServiceDes"& _ 
            "criptionInfo", ReplyAction:="http://Microsoft.ServiceModel.Samples/IServiceDescriptionCalculator/GetServiceDes"& _ 
            "criptionInfoResponse")>  _
        Function GetServiceDescriptionInfo() As String
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface IServiceDescriptionCalculatorChannel
        Inherits Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class ServiceDescriptionCalculatorClient
        Inherits System.ServiceModel.ClientBase(Of Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator)
        Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Add(ByVal n1 As Integer, ByVal n2 As Integer) As Integer Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator.Add
            Return MyBase.Channel.Add(n1, n2)
        End Function
        
        Public Function Subtract(ByVal n1 As Integer, ByVal n2 As Integer) As Integer Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator.Subtract
            Return MyBase.Channel.Subtract(n1, n2)
        End Function
        
        Public Function Multiply(ByVal n1 As Integer, ByVal n2 As Integer) As Integer Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator.Multiply
            Return MyBase.Channel.Multiply(n1, n2)
        End Function
        
        Public Function Divide(ByVal n1 As Integer, ByVal n2 As Integer) As Integer Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator.Divide
            Return MyBase.Channel.Divide(n1, n2)
        End Function
        
        Public Function GetServiceDescriptionInfo() As String Implements Microsoft.ServiceModel.Samples.IServiceDescriptionCalculator.GetServiceDescriptionInfo
            Return MyBase.Channel.GetServiceDescriptionInfo
        End Function
    End Class
End Namespace
