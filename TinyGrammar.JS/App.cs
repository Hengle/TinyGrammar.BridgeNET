﻿using Bridge;
using Bridge.Html5;
using MB.TinyGrammar.Core;
using MB.TinyGrammar.Core.Parsers;
using System;

namespace TinyGrammar.JS
{
    public class App
    {
        public static void Main()
        {
            string myGrammar;

            myGrammar = @"{periodo}:{pre_inizio}{frase}; {pre_durante}{frase}; {pre_fine}{frase}
{periodo}:{pre_inizio}{frase}; {pre_durante}{frase}
{periodo}:{pre_inizio}{frase}; {pre_durante}{frase}
{periodo}:{pre_inizio}{frase}; {pre_fine}{frase}
{periodo}:{pre_inizio}{frase}; {pre_fine}{frase}
{periodo}:per {frase_semplice}:<br/> 1. {frase}<br/> 2. {frase}<br/> 3. {frase}
{periodo}:{frase_semplice}: come {frase_semplice} senza {frase_semplice}
{pre_durante}:{contesto_periodo_durante}, il sistema dovrà consentire di 
{pre_durante}:{contesto_periodo_durante}, l'obiettivo sarà 
{pre_durante}:dovremo, {contesto_periodo_durante}, valutare se 
{pre_durante}:forniremo supporto operativo nel 
{pre_durante}:decideremo {contesto_periodo_durante}, assieme al Cliente, come 
{pre_durante}:sarà fondamentale, {contesto_periodo_durante}, 
{pre_durante}:sarà prioritario, {contesto_periodo_durante}, 
{pre_durante}:creeremo, {contesto_periodo_durante}, {soggetto} per 
{pre_durante}:svilupperemo {contesto_periodo_durante} {soggetto} per 
{pre_durante}:dovremo, {contesto_periodo_durante}, 
{pre_durante}:e' stato richiesto {contesto_periodo_durante} di 
{pre_durante}:il Cliente ha richiesto {contesto_periodo_durante} di 
{pre_durante}:ci si aspetta {contesto_periodo_durante} di poter 
{pre_durante}:il sistema {contesto_periodo_durante} dovrà 
{pre_durante}:il software {contesto_periodo_durante} permetterà di 
{pre_durante}:bisognerà {contesto_periodo_durante} valutare, in funzione del budget disponibile, se 
{pre_durante}:in vista di future richieste, predisporremo {contesto_periodo_durante} {soggetto} per 
{pre_durante}:{contesto_periodo_durante}, un nostro partner si occuperà di {verbo} {soggetto} per 
{pre_durante}:{contesto_periodo_durante}, invieremo un nostro tecnico per 
{pre_durante}:il reparto R&D si occuperà, {contesto_periodo_durante}, di {verbo} {soggetto} per 
{pre_durante}:il tuning di {soggetto} consentirà {contesto_periodo_durante} di 
{pre_durante}:si metteranno a calendario {contesto_periodo_durante} le attività per 
{pre_durante}:per la messa in produzione, sarà necessario 
{pre_durante}:per non bloccare l'operatività del Cliente, sarà necessario 
{pre_durante}:sarà {contesto_periodo_durante} necessario 
{pre_durante}:compatibilmente con le tempistiche, il team si occuperà di 
{pre_durante}:se non si troverà un modo per {frase_semplice}, dovremo 
{pre_durante}:il nostro responsabile tecnico dovrà, {contesto_periodo_durante}, stimare le giornate uomo necessarie per 
{pre_durante}:definiremo {contesto_periodo_durante} un workflow per 
{pre_durante}:si dovrà, {contesto_periodo_durante}, studiare una soluzione integrata per 
{pre_durante}:{contesto_periodo_durante}, si dovrà implementare un algoritmo per 
{pre_durante}:bisognerà {contesto_periodo_durante} 
{pre_durante}:valutaremo {contesto_periodo_durante} l'uso di {soggetto} per 
{pre_durante}:si valuterà, {contesto_periodo_durante}, se sia possibile 
{pre_durante}:si ritiene opportuno, {contesto_periodo_durante}, 
{pre_durante}:la soluzione sarà progettata per 
{pre_durante}:sarà aggiunto {contesto_periodo_durante} un campo per 
{pre_durante}:le modifiche coinvolgeranno {soggetto} così da 
{pre_durante}:gli interventi {contesto_periodo_durante} saranno funzionali a 
{verbo}:aggiornare
{verbo}:automatizzare la creazione di
{verbo}:censire
{verbo}:configurare
{verbo}:compattare
{verbo}:compilare
{verbo}:connettere in https {soggetto} con
{verbo}:controllare da remoto
{verbo}:convertire in Unicode
{verbo}:creare un modello per
{verbo}:creare
{verbo}:duplicare
{verbo}:deduplicare
{verbo}:ridefinire
{verbo}:dimensionare
{verbo}:decentralizzare
{verbo}:elaborare
{verbo}:estrarre
{verbo}:fare il refactoring di
{verbo}:fare l'upgrade di
{verbo}:fornire l'accesso a
{verbo}:generare ex novo
{verbo}:gestire
{verbo}:identificare
{verbo}:importare
{verbo}:incapsulare
{verbo}:interconnettere {soggetto} con
{verbo}:monitorare
{verbo}:mettere in cluster
{verbo}:ottimizzare
{verbo}:prototipare
{verbo}:rappresentare
{verbo}:redirezionare
{verbo}:remotizzare
{verbo}:rendere multilingua
{verbo}:rendere Service Oriented
{verbo}:gestire in modo proattivo
{verbo}:simulare
{verbo}:standardizzare
{verbo}:taggare
{verbo}:testare
{verbo}:validare
{verbo}:migliorare l'uptime di
{verbo}:virtualizzare
{verbo}:verticalizzare
{verbo}:verificare la compatibilità di
{verbo}:normalizzare
{complemento_complesso}: (anche {complemento})
{complemento_complesso}: (meglio {complemento})
{complemento_complesso}: (preferibilmente {complemento})
{complemento_complesso}: (possibilmente {complemento})
{complemento_complesso}: (opzionalmente {complemento})
{complemento_complesso}: (il tutto {complemento})
{complemento_complesso}: (in corso d'opera si valuterà se operare {complemento} o meno)
{contesto_periodo_durante}:poi
{contesto_periodo_durante}:in seguito
{contesto_periodo_durante}:quindi
{contesto_periodo_durante}:perciò
{contesto_periodo_durante}:contestualmente
{contesto_periodo_durante}:inoltre
{contesto_periodo_durante}:successivamente
{pre_inizio}:{contesto_periodo_inizio}, il sistema dovrà consentire di 
{pre_inizio}:{contesto_periodo_inizio}, l'obiettivo sarà 
{pre_inizio}:dovremo, {contesto_periodo_inizio}, valutare se 
{pre_inizio}:forniremo supporto operativo nel 
{pre_inizio}:decideremo {contesto_periodo_inizio}, assieme al Cliente, come 
{pre_inizio}:sarà fondamentale, {contesto_periodo_inizio}, 
{pre_inizio}:sarà prioritario, {contesto_periodo_inizio}, 
{pre_inizio}:creeremo, {contesto_periodo_inizio}, {soggetto} per 
{pre_inizio}:svilupperemo {contesto_periodo_inizio} {soggetto} per 
{pre_inizio}:dovremo, {contesto_periodo_inizio}, 
{pre_inizio}:e' stato richiesto {contesto_periodo_inizio} di 
{pre_inizio}:il Cliente ha richiesto {contesto_periodo_inizio} di 
{pre_inizio}:ci si aspetta {contesto_periodo_inizio} di poter 
{pre_inizio}:il sistema {contesto_periodo_inizio} dovrà 
{pre_inizio}:il software {contesto_periodo_inizio} permetterà di 
{pre_inizio}:bisognerà {contesto_periodo_inizio} valutare, in funzione del budget disponibile, se 
{pre_inizio}:in vista di future richieste, predisporremo {contesto_periodo_inizio} {soggetto} per 
{pre_inizio}:{contesto_periodo_inizio}, un nostro partner si occuperà di {verbo} {soggetto} per 
{pre_inizio}:{contesto_periodo_inizio}, invieremo un nostro tecnico per 
{pre_inizio}:il reparto R&D si occuperà, {contesto_periodo_inizio}, di {verbo} {soggetto} per 
{pre_inizio}:il tuning di {soggetto} consentirà {contesto_periodo_inizio} di 
{pre_inizio}:si metteranno a calendario {contesto_periodo_inizio} le attività per 
{pre_inizio}:per la messa in produzione, sarà necessario 
{pre_inizio}:per non bloccare l'operatività del Cliente, sarà necessario 
{pre_inizio}:sarà {contesto_periodo_inizio} necessario 
{pre_inizio}:compatibilmente con le tempistiche, il team si occuperà di 
{pre_inizio}:se non si troverà un modo per {frase_semplice}, dovremo 
{pre_inizio}:il nostro responsabile tecnico dovrà, {contesto_periodo_inizio}, stimare le giornate uomo necessarie per 
{pre_inizio}:definiremo {contesto_periodo_inizio} un workflow per 
{pre_inizio}:si dovrà, {contesto_periodo_inizio}, studiare una soluzione integrata per 
{pre_inizio}:{contesto_periodo_inizio}, si dovrà implementare un algoritmo per 
{pre_inizio}:bisognerà {contesto_periodo_inizio} 
{pre_inizio}:valutaremo {contesto_periodo_inizio} l'uso di {soggetto} per 
{pre_inizio}:si valuterà, {contesto_periodo_inizio}, se sia possibile 
{pre_inizio}:si ritiene opportuno, {contesto_periodo_inizio}, 
{pre_inizio}:la soluzione sarà progettata per 
{pre_inizio}:sarà aggiunto {contesto_periodo_inizio} un campo per 
{pre_inizio}:le modifiche coinvolgeranno {soggetto} così da 
{pre_inizio}:gli interventi {contesto_periodo_inizio} saranno funzionali a 
{pre}:{contesto_periodo}, il sistema dovrà consentire di 
{pre}:{contesto_periodo}, l'obiettivo sarà 
{pre}:dovremo, {contesto_periodo}, valutare se 
{pre}:forniremo supporto operativo nel 
{pre}:decideremo {contesto_periodo}, assieme al Cliente, come 
{pre}:sarà fondamentale, {contesto_periodo}, 
{pre}:sarà prioritario, {contesto_periodo}, 
{pre}:creeremo, {contesto_periodo}, {soggetto} per 
{pre}:svilupperemo {contesto_periodo} {soggetto} per 
{pre}:dovremo, {contesto_periodo}, 
{pre}:e' stato richiesto {contesto_periodo} di 
{pre}:il Cliente ha richiesto {contesto_periodo} di 
{pre}:ci si aspetta {contesto_periodo} di poter 
{pre}:il sistema {contesto_periodo} dovrà 
{pre}:il software {contesto_periodo} permetterà di 
{pre}:bisognerà {contesto_periodo} valutare, in funzione del budget disponibile, se 
{pre}:in vista di future richieste, predisporremo {contesto_periodo} {soggetto} per 
{pre}:{contesto_periodo}, un nostro partner si occuperà di {verbo} {soggetto} per 
{pre}:{contesto_periodo}, invieremo un nostro tecnico per 
{pre}:il reparto R&D si occuperà, {contesto_periodo}, di {verbo} {soggetto} per 
{pre}:il tuning di {soggetto} consentirà {contesto_periodo} di 
{pre}:si metteranno a calendario {contesto_periodo} le attività per 
{pre}:per la messa in produzione, sarà necessario 
{pre}:per non bloccare l'operatività del Cliente, sarà necessario 
{pre}:sarà {contesto_periodo} necessario 
{pre}:compatibilmente con le tempistiche, il team si occuperà di 
{pre}:se non si troverà un modo per {frase_semplice}, dovremo 
{pre}:il nostro responsabile tecnico dovrà, {contesto_periodo}, stimare le giornate uomo necessarie per 
{pre}:definiremo {contesto_periodo} un workflow per 
{pre}:si dovrà, {contesto_periodo}, studiare una soluzione integrata per 
{pre}:{contesto_periodo}, si dovrà implementare un algoritmo per 
{pre}:bisognerà {contesto_periodo} 
{pre}:valutaremo {contesto_periodo} l'uso di {soggetto} per 
{pre}:si valuterà, {contesto_periodo}, se sia possibile 
{pre}:si ritiene opportuno, {contesto_periodo}, 
{pre}:la soluzione sarà progettata per 
{pre}:sarà aggiunto {contesto_periodo} un campo per 
{pre}:le modifiche coinvolgeranno {soggetto} così da 
{pre}:gli interventi {contesto_periodo} saranno funzionali a 
{contesto_periodo_fine}:infine
{contesto_periodo_fine}:contestualmente
{contesto_periodo_fine}:al momento della consegna
{contesto_periodo_fine}:al termine dell'attività
{contesto_periodo_fine}:prima del collaudo finale
{contesto_periodo_fine}:in conclusione
{contesto_periodo_fine}:al termine dei lavori
{contesto_periodo_fine}:a completamento del progetto
{contesto_periodo_fine}:terminata la realizzazione
{contesto_periodo}:
{titolo}:{frase_semplice}
{titolo}:{frase_semplice} e {frase_semplice}
{titolo}:{frase_semplice}: come {frase_semplice}
{titolo}:{frase_semplice}: analisi tecnica
{titolo}:{frase_semplice}: studio di fattibilità
{titolo}:come {frase_semplice}
{titolo}:{soggetto}: implementazione
{titolo}:{soggetto}: valutazione
{titolo}:{soggetto}
{titolo}:{soggetto} {complemento}
{titolo}:come {verbo} {soggetto}
{titolo}:connettere {soggetto} con {soggetto}
{titolo}:integrazione per {verbo} {soggetto}
{frase}:{frase_semplice}{complemento_opzionale}
{frase_semplice}:{verbo} {soggetto}
{complemento}:ad alta coesione
{complemento}:ad alta usabilità
{complemento}:ad alta scalabilità
{complemento}:ad alte performance
{complemento}:ad hoc
{complemento}:a plug-in
{complemento}:da un Iphone
{complemento}:embedded
{complemento}:riassegnando le priorità
{complemento}:automaticamente
{complemento}:client-server
{complemento}:con aspect oriented programming
{complemento}:con cache
{complemento}:con codifica Json
{complemento}:con metodologie agili
{complemento}:con filtro dinamico
{complemento}:con Scrum
{complemento}:con un plugin di wordpress
{complemento}:notificando il tutto con twitter
{complemento}:con notifica asincrona
{complemento}:con parametri
{complemento}:con ridondanza
{complemento}:con un'interfaccia astratta
{complemento}:da palmare
{complemento}:da Android o IPhone
{complemento}:domain driven
{complemento}:event-driven
{complemento}:high-integrity
{complemento}:in Ajax
{complemento}:condividendo le informazioni
{complemento}:in base a un file di configurazione
{complemento}:in bytecode
{complemento}:in funzione dell'utente
{complemento}:in logica combinatoria
{complemento}:in multithreading
{complemento}:ricorsivamente
{complemento}:in modalità concorrente
{complemento}:in modo sincrono
{complemento}:in modalità contestuale
{complemento}:in Ruby
{complemento}:in Python
{complemento}:in html5
{complemento}:in una logica distribuita
{complemento}:just in time
{complemento}:lato server
{complemento}:lato client
{complemento}:offline
{complemento}:on demand
{complemento}:one-to-one
{complemento}:seo oriented
{complemento}:rimanendo cross platform
{complemento}:secondo una logica Web 2.0
{complemento}:state-less
{complemento}:uno a molti
{complemento}:utilizzando attributi
{complemento}:via Sms
{complemento}:ottimizzando per i motori di ricerca
{complemento}:W3C compliant
{complemento}:multicore
{complemento}:nei tempi previsti
{complemento}:autonomamente
{complemento}:aggiornando {soggetto} in automatico
{complemento}:mediante {soggetto} Open Source
{complemento}:attraverso un algoritmo basato su {soggetto}
{complemento}:con accesso diretto a {soggetto}
{complemento}:con {soggetto} per il load balancing
{complemento}:con {soggetto} su Linux
{complemento}:con {soggetto} su Solaris
{complemento}:proattivamente
{complemento}:tramite aggiornamento di {soggetto}
{complemento}:comunicando con {soggetto}
{complemento}:delegando a {soggetto} la security
{complemento}:con un token fornito da {soggetto}
{complemento}:mediante l'aggiunta di {soggetto}
{complemento}:mantenendo la compatibilità con .net 2.0
{complemento}:mantenendo la retrocompatibilità
{complemento}:secondo un protocollo concordato
{complemento}:su Excel
{complemento}:mediante un proxy COM
{complemento}:in realtime
{complemento}:dando notifica a {soggetto} in realtime
{complemento}:organizzando {soggetto} in base a {soggetto}
{complemento}:prevedendo {soggetto} di backup
{complemento}:creando {soggetto} in funzione di {soggetto}
{complemento}:ricorrendo eventualmente a {soggetto}
{complemento}:usando {soggetto} come proxy
{complemento}:usando {soggetto} come provider
{complemento}:utilizzando {soggetto} come sorgente
{complemento}:utilizzando {soggetto}
{complemento}:validando {soggetto}
{complemento}:verificando {soggetto} attraverso {soggetto}
{complemento}:di nicchia
{complemento}:con i consueti strumenti
{complemento}:{complemento_complesso}
{complemento}:{complemento_complesso}
{complemento}:{complemento_complesso}
{complemento}:{complemento_complesso}
{pre_opzionale}:
{pre_opzionale}:{pre} 
{soggetto}:un db relazionale
{soggetto}:un'architettura a livelli
{soggetto}:un mockup
{soggetto}:un proxy
{soggetto}:un device esterno
{soggetto}:un server virtualizzato
{soggetto}:un applicativo Java
{soggetto}:un controller Mvc
{soggetto}:un social network verticale
{soggetto}:un cubo Olap
{soggetto}:API asincrone
{soggetto}:una coda di messaggi
{soggetto}:set di dati disconnessi
{soggetto}:un profilo Facebook
{soggetto}:librerie Enterprise Java Beans
{soggetto}:entità logiche
{soggetto}:un flusso bidirezionale
{soggetto}:flussi di informazione
{soggetto}:un firmware
{soggetto}:una Gui interattiva
{soggetto}:un header JMS
{soggetto}:un set di oggetti connessi
{soggetto}:uno o più oggetti Pojo
{soggetto}:oggetti remoti
{soggetto}:una pagina Web
{soggetto}:una o più mappe logiche
{soggetto}:matrici bidimensionali
{soggetto}:messaggi Soap
{soggetto}:record strutturati
{soggetto}:proprietà read-only
{soggetto}:dei record di dati
{soggetto}:una libreria di funzioni customizzabili
{soggetto}:un Rss feed
{soggetto}:sistemi di autenticazione Ldap
{soggetto}:sistemi Active Directory
{soggetto}:sistemi distribuiti
{soggetto}:soggetti attivi
{soggetto}:strutture eterogenee
{soggetto}:uno stream Xml
{soggetto}:un account virtuale
{soggetto}:un applicativo Silverlight
{soggetto}:messaggi Corba
{soggetto}:un grafo bilanciato
{soggetto}:un indice univoco
{soggetto}:un log di eventi
{soggetto}:un oggetto clustered
{soggetto}:un sistema Web 3.0
{soggetto}:un sistema ecommerce
{soggetto}:un sistema distribuito
{soggetto}:un accesso differenziato
{soggetto}:un Web Service
{soggetto}:un social network
{soggetto}:un campo automatico
{complemento_opzionale}: {complemento}
{complemento_opzionale}:
{complemento_opzionale}:
{complemento_opzionale}:
{negazione_opzionale}:non 
{negazione_opzionale}:
{contesto_periodo_inizio}:innanzitutto
{contesto_periodo_inizio}:inizialmente
{contesto_periodo_inizio}:per prima cosa
{contesto_periodo_inizio}:per lo startup
{contesto_periodo_inizio}:nella prima fase
{contesto_periodo_inizio}:nelle fasi iniziali
{contesto_periodo_inizio}:per la prima milestone
{contesto_periodo_inizio}:per la prima demo
{contesto_periodo_inizio}:dapprima
{pre_fine}:{contesto_periodo_fine}, il sistema dovrà consentire di 
{pre_fine}:{contesto_periodo_fine}, l'obiettivo sarà 
{pre_fine}:dovremo, {contesto_periodo_fine}, valutare se 
{pre_fine}:forniremo supporto operativo nel 
{pre_fine}:decideremo {contesto_periodo_fine}, assieme al Cliente, come 
{pre_fine}:sarà fondamentale, {contesto_periodo_fine}, 
{pre_fine}:sarà prioritario, {contesto_periodo_fine}, 
{pre_fine}:creeremo, {contesto_periodo_fine}, {soggetto} per 
{pre_fine}:svilupperemo {contesto_periodo_fine} {soggetto} per 
{pre_fine}:dovremo, {contesto_periodo_fine}, 
{pre_fine}:e' stato richiesto {contesto_periodo_fine} di 
{pre_fine}:il Cliente ha richiesto {contesto_periodo_fine} di 
{pre_fine}:ci si aspetta {contesto_periodo_fine} di poter 
{pre_fine}:il sistema {contesto_periodo_fine} dovrà 
{pre_fine}:il software {contesto_periodo_fine} permetterà di 
{pre_fine}:bisognerà {contesto_periodo_fine} valutare, in funzione del budget disponibile, se 
{pre_fine}:in vista di future richieste, predisporremo {contesto_periodo_fine} {soggetto} per 
{pre_fine}:{contesto_periodo_fine}, un nostro partner si occuperà di {verbo} {soggetto} per 
{pre_fine}:{contesto_periodo_fine}, invieremo un nostro tecnico per 
{pre_fine}:il reparto R&D si occuperà, {contesto_periodo_fine}, di {verbo} {soggetto} per 
{pre_fine}:il tuning di {soggetto} consentirà {contesto_periodo_fine} di 
{pre_fine}:si metteranno a calendario {contesto_periodo_fine} le attività per 
{pre_fine}:per la messa in produzione, sarà necessario 
{pre_fine}:per non bloccare l'operatività del Cliente, sarà necessario 
{pre_fine}:sarà {contesto_periodo_fine} necessario 
{pre_fine}:compatibilmente con le tempistiche, il team si occuperà di 
{pre_fine}:se non si troverà un modo per {frase_semplice}, dovremo 
{pre_fine}:il nostro responsabile tecnico dovrà, {contesto_periodo_fine}, stimare le giornate uomo necessarie per 
{pre_fine}:definiremo {contesto_periodo_fine} un workflow per 
{pre_fine}:si dovrà, {contesto_periodo_fine}, studiare una soluzione integrata per 
{pre_fine}:{contesto_periodo_fine}, si dovrà implementare un algoritmo per 
{pre_fine}:bisognerà {contesto_periodo_fine} 
{pre_fine}:valutaremo {contesto_periodo_fine} l'uso di {soggetto} per 
{pre_fine}:si valuterà, {contesto_periodo_fine}, se sia possibile 
{pre_fine}:si ritiene opportuno, {contesto_periodo_fine}, 
{pre_fine}:la soluzione sarà progettata per 
{pre_fine}:sarà aggiunto {contesto_periodo_fine} un campo per 
{pre_fine}:le modifiche coinvolgeranno {soggetto} così da 
{pre_fine}:gli interventi {contesto_periodo_fine} saranno funzionali a";

            // Create a new HTML Button
            var button = new HTMLButtonElement();
            var paragraph = new HTMLParagraphElement();
            var div = new HTMLTextAreaElement();
            div.Rows = 5;
            div.Cols = 80;
            paragraph.AppendChild(div);

            button.InnerHTML = "Get some fuffa";

            button.OnClick = (ev) =>
            {
                var parser = new TextParser();
                Grammar g;

                try
                {
                    g = parser.GrammarFromText(myGrammar);
                    Sentence result;
                    result = g.ApplyAllSubstitutions();
                    div.TextContent = result.FinalOutput;
                    //Console.WriteLine(result.FinalOutput);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Grammar parsing error");                    
                }
            };

            Document.Body.AppendChild(button);           
            Document.Body.AppendChild(paragraph);
        }
    }
}