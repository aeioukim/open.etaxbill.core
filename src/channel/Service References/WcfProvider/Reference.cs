﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenETaxBill.WcfProvider {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07", ConfigurationName="WcfProvider.IProviderService")]
    public interface IProviderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Wri" +
            "teLog", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Wri" +
            "teLogResponse")]
        void WriteLog(System.Guid p_certapp, string p_exception, string p_message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Wri" +
            "teLog", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Wri" +
            "teLogResponse")]
        System.Threading.Tasks.Task WriteLogAsync(System.Guid p_certapp, string p_exception, string p_message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Hel" +
            "loWorld", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Hel" +
            "loWorldResponse")]
        string HelloWorld(System.Guid p_certapp, string p_greeting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Hel" +
            "loWorld", ReplyAction="http://www.odinsoftware.co.kr/open/etaxbill/provider/2016/07/IProviderService/Hel" +
            "loWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync(System.Guid p_certapp, string p_greeting);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProviderServiceChannel : OpenETaxBill.WcfProvider.IProviderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProviderServiceClient : System.ServiceModel.ClientBase<OpenETaxBill.WcfProvider.IProviderService>, OpenETaxBill.WcfProvider.IProviderService {
        
        public ProviderServiceClient() {
        }
        
        public ProviderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProviderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProviderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProviderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void WriteLog(System.Guid p_certapp, string p_exception, string p_message) {
            base.Channel.WriteLog(p_certapp, p_exception, p_message);
        }
        
        public System.Threading.Tasks.Task WriteLogAsync(System.Guid p_certapp, string p_exception, string p_message) {
            return base.Channel.WriteLogAsync(p_certapp, p_exception, p_message);
        }
        
        public string HelloWorld(System.Guid p_certapp, string p_greeting) {
            return base.Channel.HelloWorld(p_certapp, p_greeting);
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync(System.Guid p_certapp, string p_greeting) {
            return base.Channel.HelloWorldAsync(p_certapp, p_greeting);
        }
    }
}
