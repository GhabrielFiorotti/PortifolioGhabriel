var client = new RestClient("https://egestorab.saude.gov.br/paginas/acessoPublico/inscricaoMailing.xhtml");
var request = new RestRequest(Method.POST);
request.AddHeader("Postman-Token", "aa2f505c-8bc1-4a16-836e-79940af0602f");
request.AddHeader("cache-control", "no-cache");
request.AddHeader("Cookie", "_ga=GA1.3.1354079618.1575407388; JSESSIONID=nUcLorjn0kGCzFfx2e6dUR34; BIGipServeregestorab_prod=1661017516.8225.0000; _gid=GA1.3.813522091.1575590736; _gat_gtag_UA_117915284_1=1");
request.AddHeader("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");
request.AddParameter("undefined", "form1=form1&javax.faces.ViewState=1741574807867118689%3A-4717071107438391420&form1%3Acampo-cpf=18746379703&form1%3Aj_idt68=BUSCAR&form1%3Aj_idt94=S&form1%3Aremember=on&javax.faces.source=form1%3Acampo-cpf&javax.faces.partial.event=change&javax.faces.partial.execute=form1%3Acampo-cpf%20form1%3Acampo-cpf&javax.faces.partial.render=form1&javax.faces.behavior.event=valueChange&javax.faces.partial.ajax=true", ParameterType.RequestBody);
IRestResponse response = client.Execute(request);