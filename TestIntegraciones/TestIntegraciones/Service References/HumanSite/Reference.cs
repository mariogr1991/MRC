﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestIntegraciones.HumanSite {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="KB9EVO235", ConfigurationName="HumanSite.WSInfoUnidadNegocioSoapPort")]
    public interface WSInfoUnidadNegocioSoapPort {
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETUNIDADNEGOCIO", ReplyAction="*")]
        TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse GETUNIDADNEGOCIO(TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETUNIDADNEGOCIO", ReplyAction="*")]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse> GETUNIDADNEGOCIOAsync(TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETINFOEMPLEADO", ReplyAction="*")]
        TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse GETINFOEMPLEADO(TestIntegraciones.HumanSite.GETINFOEMPLEADORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETINFOEMPLEADO", ReplyAction="*")]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse> GETINFOEMPLEADOAsync(TestIntegraciones.HumanSite.GETINFOEMPLEADORequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETEMPLEADOS", ReplyAction="*")]
        TestIntegraciones.HumanSite.GETEMPLEADOSResponse GETEMPLEADOS(TestIntegraciones.HumanSite.GETEMPLEADOSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETEMPLEADOS", ReplyAction="*")]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSResponse> GETEMPLEADOSAsync(TestIntegraciones.HumanSite.GETEMPLEADOSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETEMPLEADOSRELCHE", ReplyAction="*")]
        TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse GETEMPLEADOSRELCHE(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="KB9EVO235action/AWSINFOUNIDADNEGOCIO.GETEMPLEADOSRELCHE", ReplyAction="*")]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse> GETEMPLEADOSRELCHEAsync(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETUNIDADNEGOCIORequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETUNIDADNEGOCIO", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequestBody Body;
        
        public GETUNIDADNEGOCIORequest() {
        }
        
        public GETUNIDADNEGOCIORequest(TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETUNIDADNEGOCIORequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mb_epr_cod;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Comid;
        
        public GETUNIDADNEGOCIORequestBody() {
        }
        
        public GETUNIDADNEGOCIORequestBody(string Mb_epr_cod, int Comid) {
            this.Mb_epr_cod = Mb_epr_cod;
            this.Comid = Comid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETUNIDADNEGOCIOResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETUNIDADNEGOCIOResponse", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponseBody Body;
        
        public GETUNIDADNEGOCIOResponse() {
        }
        
        public GETUNIDADNEGOCIOResponse(TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETUNIDADNEGOCIOResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Companiasjson;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error;
        
        public GETUNIDADNEGOCIOResponseBody() {
        }
        
        public GETUNIDADNEGOCIOResponseBody(string Companiasjson, string Error) {
            this.Companiasjson = Companiasjson;
            this.Error = Error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETINFOEMPLEADORequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETINFOEMPLEADO", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETINFOEMPLEADORequestBody Body;
        
        public GETINFOEMPLEADORequest() {
        }
        
        public GETINFOEMPLEADORequest(TestIntegraciones.HumanSite.GETINFOEMPLEADORequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETINFOEMPLEADORequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mb_epr_cod;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Emp_nie;
        
        public GETINFOEMPLEADORequestBody() {
        }
        
        public GETINFOEMPLEADORequestBody(string Mb_epr_cod, int Emp_nie) {
            this.Mb_epr_cod = Mb_epr_cod;
            this.Emp_nie = Emp_nie;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETINFOEMPLEADOResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETINFOEMPLEADOResponse", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETINFOEMPLEADOResponseBody Body;
        
        public GETINFOEMPLEADOResponse() {
        }
        
        public GETINFOEMPLEADOResponse(TestIntegraciones.HumanSite.GETINFOEMPLEADOResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETINFOEMPLEADOResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Empleadojson;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error;
        
        public GETINFOEMPLEADOResponseBody() {
        }
        
        public GETINFOEMPLEADOResponseBody(string Empleadojson, string Error) {
            this.Empleadojson = Empleadojson;
            this.Error = Error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETEMPLEADOSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETEMPLEADOS", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETEMPLEADOSRequestBody Body;
        
        public GETEMPLEADOSRequest() {
        }
        
        public GETEMPLEADOSRequest(TestIntegraciones.HumanSite.GETEMPLEADOSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETEMPLEADOSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mb_epr_cod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Puestoid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Catalogoid;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int Comid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Fechaingresostr;
        
        public GETEMPLEADOSRequestBody() {
        }
        
        public GETEMPLEADOSRequestBody(string Mb_epr_cod, string Puestoid, string Catalogoid, int Comid, string Fechaingresostr) {
            this.Mb_epr_cod = Mb_epr_cod;
            this.Puestoid = Puestoid;
            this.Catalogoid = Catalogoid;
            this.Comid = Comid;
            this.Fechaingresostr = Fechaingresostr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETEMPLEADOSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETEMPLEADOSResponse", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETEMPLEADOSResponseBody Body;
        
        public GETEMPLEADOSResponse() {
        }
        
        public GETEMPLEADOSResponse(TestIntegraciones.HumanSite.GETEMPLEADOSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETEMPLEADOSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Empleadosjson;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error;
        
        public GETEMPLEADOSResponseBody() {
        }
        
        public GETEMPLEADOSResponseBody(string Empleadosjson, string Error) {
            this.Empleadosjson = Empleadosjson;
            this.Error = Error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETEMPLEADOSRELCHERequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETEMPLEADOSRELCHE", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequestBody Body;
        
        public GETEMPLEADOSRELCHERequest() {
        }
        
        public GETEMPLEADOSRELCHERequest(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETEMPLEADOSRELCHERequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Mb_epr_cod;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Fechastr;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Comid;
        
        public GETEMPLEADOSRELCHERequestBody() {
        }
        
        public GETEMPLEADOSRELCHERequestBody(string Mb_epr_cod, string Fechastr, int Comid) {
            this.Mb_epr_cod = Mb_epr_cod;
            this.Fechastr = Fechastr;
            this.Comid = Comid;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GETEMPLEADOSRELCHEResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="WSInfoUnidadNegocio.GETEMPLEADOSRELCHEResponse", Namespace="KB9EVO235", Order=0)]
        public TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponseBody Body;
        
        public GETEMPLEADOSRELCHEResponse() {
        }
        
        public GETEMPLEADOSRELCHEResponse(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="KB9EVO235")]
    public partial class GETEMPLEADOSRELCHEResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Registrosrelchejson;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Error;
        
        public GETEMPLEADOSRELCHEResponseBody() {
        }
        
        public GETEMPLEADOSRELCHEResponseBody(string Registrosrelchejson, string Error) {
            this.Registrosrelchejson = Registrosrelchejson;
            this.Error = Error;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSInfoUnidadNegocioSoapPortChannel : TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSInfoUnidadNegocioSoapPortClient : System.ServiceModel.ClientBase<TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort>, TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort {
        
        public WSInfoUnidadNegocioSoapPortClient() {
        }
        
        public WSInfoUnidadNegocioSoapPortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSInfoUnidadNegocioSoapPortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSInfoUnidadNegocioSoapPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSInfoUnidadNegocioSoapPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETUNIDADNEGOCIO(TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest request) {
            return base.Channel.GETUNIDADNEGOCIO(request);
        }
        
        public string GETUNIDADNEGOCIO(string Mb_epr_cod, int Comid, out string Error) {
            TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest inValue = new TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Comid = Comid;
            TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse retVal = ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETUNIDADNEGOCIO(inValue);
            Error = retVal.Body.Error;
            return retVal.Body.Companiasjson;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse> TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETUNIDADNEGOCIOAsync(TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest request) {
            return base.Channel.GETUNIDADNEGOCIOAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETUNIDADNEGOCIOResponse> GETUNIDADNEGOCIOAsync(string Mb_epr_cod, int Comid) {
            TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest inValue = new TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETUNIDADNEGOCIORequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Comid = Comid;
            return ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETUNIDADNEGOCIOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETINFOEMPLEADO(TestIntegraciones.HumanSite.GETINFOEMPLEADORequest request) {
            return base.Channel.GETINFOEMPLEADO(request);
        }
        
        public string GETINFOEMPLEADO(string Mb_epr_cod, int Emp_nie, out string Error) {
            TestIntegraciones.HumanSite.GETINFOEMPLEADORequest inValue = new TestIntegraciones.HumanSite.GETINFOEMPLEADORequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETINFOEMPLEADORequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Emp_nie = Emp_nie;
            TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse retVal = ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETINFOEMPLEADO(inValue);
            Error = retVal.Body.Error;
            return retVal.Body.Empleadojson;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse> TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETINFOEMPLEADOAsync(TestIntegraciones.HumanSite.GETINFOEMPLEADORequest request) {
            return base.Channel.GETINFOEMPLEADOAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETINFOEMPLEADOResponse> GETINFOEMPLEADOAsync(string Mb_epr_cod, int Emp_nie) {
            TestIntegraciones.HumanSite.GETINFOEMPLEADORequest inValue = new TestIntegraciones.HumanSite.GETINFOEMPLEADORequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETINFOEMPLEADORequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Emp_nie = Emp_nie;
            return ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETINFOEMPLEADOAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestIntegraciones.HumanSite.GETEMPLEADOSResponse TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETEMPLEADOS(TestIntegraciones.HumanSite.GETEMPLEADOSRequest request) {
            return base.Channel.GETEMPLEADOS(request);
        }
        
        public string GETEMPLEADOS(string Mb_epr_cod, string Puestoid, string Catalogoid, int Comid, string Fechaingresostr, out string Error) {
            TestIntegraciones.HumanSite.GETEMPLEADOSRequest inValue = new TestIntegraciones.HumanSite.GETEMPLEADOSRequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETEMPLEADOSRequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Puestoid = Puestoid;
            inValue.Body.Catalogoid = Catalogoid;
            inValue.Body.Comid = Comid;
            inValue.Body.Fechaingresostr = Fechaingresostr;
            TestIntegraciones.HumanSite.GETEMPLEADOSResponse retVal = ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETEMPLEADOS(inValue);
            Error = retVal.Body.Error;
            return retVal.Body.Empleadosjson;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSResponse> TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETEMPLEADOSAsync(TestIntegraciones.HumanSite.GETEMPLEADOSRequest request) {
            return base.Channel.GETEMPLEADOSAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSResponse> GETEMPLEADOSAsync(string Mb_epr_cod, string Puestoid, string Catalogoid, int Comid, string Fechaingresostr) {
            TestIntegraciones.HumanSite.GETEMPLEADOSRequest inValue = new TestIntegraciones.HumanSite.GETEMPLEADOSRequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETEMPLEADOSRequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Puestoid = Puestoid;
            inValue.Body.Catalogoid = Catalogoid;
            inValue.Body.Comid = Comid;
            inValue.Body.Fechaingresostr = Fechaingresostr;
            return ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETEMPLEADOSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETEMPLEADOSRELCHE(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest request) {
            return base.Channel.GETEMPLEADOSRELCHE(request);
        }
        
        public string GETEMPLEADOSRELCHE(string Mb_epr_cod, string Fechastr, int Comid, out string Error) {
            TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest inValue = new TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Fechastr = Fechastr;
            inValue.Body.Comid = Comid;
            TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse retVal = ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETEMPLEADOSRELCHE(inValue);
            Error = retVal.Body.Error;
            return retVal.Body.Registrosrelchejson;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse> TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort.GETEMPLEADOSRELCHEAsync(TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest request) {
            return base.Channel.GETEMPLEADOSRELCHEAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestIntegraciones.HumanSite.GETEMPLEADOSRELCHEResponse> GETEMPLEADOSRELCHEAsync(string Mb_epr_cod, string Fechastr, int Comid) {
            TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest inValue = new TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequest();
            inValue.Body = new TestIntegraciones.HumanSite.GETEMPLEADOSRELCHERequestBody();
            inValue.Body.Mb_epr_cod = Mb_epr_cod;
            inValue.Body.Fechastr = Fechastr;
            inValue.Body.Comid = Comid;
            return ((TestIntegraciones.HumanSite.WSInfoUnidadNegocioSoapPort)(this)).GETEMPLEADOSRELCHEAsync(inValue);
        }
    }
}
