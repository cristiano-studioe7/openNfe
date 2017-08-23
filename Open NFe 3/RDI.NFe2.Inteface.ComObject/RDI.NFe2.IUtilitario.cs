﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using RDI.NFe2.SchemaXML;
using RDI.OpenSigner;

public interface IUtilitario
{

    String GetUltimaValidacao();

    void SetUtilitario_v1(String nomeCertificado, Boolean ContaComputador, Boolean Producao, Boolean TpEmisNormal, String UF);
    void SetUtilitario_v2(String nomeCertificado, Boolean ContaComputador, Boolean Producao, Boolean TpEmisNormal, String UF, int versao);
    void SetUtilitario_v3(String nomeCertificado, Boolean ContaComputador, Boolean Producao, Boolean TpEmisNormal, String UF, Boolean NFCe, int versao);
    void SetUtilitario_v4(String nomeCertificado, Boolean ContaComputador, Boolean Producao, Boolean TpEmisNormal, String UF, TipoConexao conexao, int versao);
    void SetUtilitario_v5(String nomeCertificado, Boolean ContaComputador, Boolean Producao, Boolean TpEmisNormal, String UF, TipoConexao conexao, BuscaCertificado tipoBusca, int versao);

    void DefineUF(String UF);
    void DefineUF(TCodUfIBGE UF);


    /// <summary>
    /// abre um dialogo para que o certificado possa ser selecionado pelo usuario
    /// </summary>
    /// <param name="ContaComputador">true - busca certificado em LocalMachine; false - busca certificado em CurrentUser</param>
    /// <returns>se encontrado - subject do certificado; senao -  String.Empty</returns>
    string BuscaCertificados(String valor);


    /// <summary>
    /// Assina um arquivo XML de acordo com a uri recebida como parametro.
    /// </summary>
    /// <param name="nomeCertificado">Subject do Certificado que será utilizado na assinatura do arquivo XML</param>
    /// <param name="caminhoArquivoOrigem">Origem do arquivo XML</param>
    /// <param name="uri">Uri que será assinada</param>
    /// <param name="caminhoArquivoDestino">Destino do arquivo XML</param>
    /// <param name="ContaComputador">true - busca certificado em LocalMachine; false - busca certificado em CurrentUser</param>
    /// <returns> 0 - assinado com sucesso
    ///  1 - Erro: Problema ao acessar o certificado digital - %exceção%
    ///extinto  2 - Problemas no certificado digital
    ///  3 - XML mal formado + exceção
    ///  4 - A tag de assinatura %RefUri% inexiste
    ///  5 - A tag de assinatura %RefUri% não é unica
    ///extinto  6 - Erro Ao assinar o documento - ID deve ser string %RefUri(Atributo)%
    ///  7 - Erro: Ao assinar o documento - %exceção%
    /// 11 - arquivo de origem nao existe</returns>
    int AssinaXMLHD(String caminhoArquivoOrigem, String uri,
                        String caminhoArquivoDestino);

    String AssinaXMLST(String ArquivoOrigem, String uri);
    TRetornoAssinatura AssinaXML(String xml, String uri, out string xmlAssinado);

    String ValidaXML(String caminhoXML, String caminhoXSD);

    void DefineNomeCertificado(String NomeCertificado);

    void DefineContaComputador(Boolean ContaComputador);

    void DefineProxy(String usuario, String senha, String dominio, String url);

    void SetProxy(Boolean habilita);


    //carregando do HD
    Boolean RecepcaoNFe2HD(String caminhoArquivoEnviNFe2, String caminhoArquivoRetEnviNFe2);

    Boolean RetRecepcaoNFe2HD(String caminhoArquivoConsReciNFe2, String caminhoArquivoRetConsReciNFe2);

    Boolean InutilizaNFe2HD(String caminhoArquivoInutNFe2, String caminhoArquivoRetInutNFe2);

    Boolean StatusWebServiceHD(String caminhoArquivoRetConsStatServ);

    //passando xml via string
    String RecepcaoNFe2ST(String ArquivoEnviNFe2);

    String RetRecepcaoNFe2ST(String ArquivoConsReciNFe2);

    String InutilizaNFe2ST(String ArquivoInutNFe2);

    Boolean StatusWebServiceST();

    //carregando do HD
    Boolean RecepcaoEventoHD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);

    Boolean ConsultaSituacao201NFeHD(String caminhoArquivoConsSitNFe, String caminhoArquivoRetConsSitNFe);

    //passando xml via string
    String RecepcaoEventoST(String ArquivoEnvEvento);

    String ConsultaSituacao201NFeST(String ArquivoConsSitNFe);

    #region NFCe

    //carregando do HD
    Boolean AutorizacaoNFCe3HD(String caminhoArquivoEnviNFCe3, String caminhoArquivoRetEnviNFCe3);

    Boolean RetAutorizacaoNFCe3HD(String caminhoArquivoConsReciNFCe3, String caminhoArquivoRetConsReciNFCe3);

    Boolean InutilizaNFCe3HD(String caminhoArquivoInutNFCe3, String caminhoArquivoRetInutNFCe3);



    //passando xml via string
    String AutorizacaoNFCe3ST(String ArquivoEnviNFCe3);

    String RetAutorizacaoNFCe3ST(String ArquivoConsReciNFCe3);

    String InutilizaNFCe3ST(String ArquivoInutNFCe3);


    //carregando do HD
    Boolean RecepcaoEventoNFCe3HD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);

    Boolean ConsultaSituacaoNFCe3HD(String caminhoArquivoConsSitNFCe3, String caminhoArquivoRetConsSitNFCe3);

    //passando xml via string
    String RecepcaoEventoNFCe3ST(String ArquivoEnvEvento);

    String ConsultaSituacaoNFCe3ST(String ArquivoConsSitNFCe3);

    #endregion

    Boolean ConsultaCadastroHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String ConsultaCadastroST(String XMLEnvio);

    Boolean ConsultarDFeHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String ConsultarDFeST(String XMLEnvio);

    Boolean DownloadNFHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String DownloadNFST(String XMLEnvio);

    String RecepcaoEvento_MDe_ST(String ArquivoEnvEvento);
    Boolean RecepcaoEvento_MDe_HD(String caminhoArquivoEnvEvento, String caminhoArquivoRetEnvEvento);

    string Unzip(string stZipped);

    Boolean GNRE_RecepcaoLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_RecepcaoLoteST(String XMLEnvio);

    Boolean GNRE_ConsultaLoteHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_ConsultaLoteST(String XMLEnvio);

    Boolean GNRE_ConsultaConfigHD(String caminhoXMLEnvio, String caminhoXMLRetorno);
    String GNRE_ConsultaConfigST(String XMLEnvio);



}
