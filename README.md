# PrometheusDotNetPOC
POC to trainning resources of Prometheus at a .Net Core WebApi

# Overview
O Prometheus é uma ferramenta de monitoramento que obtem, de forma ativa (pulling) métricas de aplicações. O pull é feito em um path '/metrics' da aplicação (isso é pré-requisito), dessa maneira se os dados nesse path estiverem no formato entendível ao Prometheus, o mesmo pega essas informações e as armazena. Este projeto serve para se treinar as funcionalidades básicas do Prometheus do ponto de vista de uma aplicação .Net Core. 

# Metricas
Há 4 tipos de métricas possíveis para se gerar no '/metrics' da aplicação para que o Prometheus pegue as informações:
*** Counters:** métricas de contagem nas quais os valores só aumentam. Exemplo: número de acessos a um site ao longo do tempo. 
* Gauges: métricas que possuem valor arbitrário, em um momento pode ser um valor, no momento seguinte pode ser outro totalmente diferente. Exemplo: número de usuários logados em um site em um momento específico do dia. 
* Histogram: métricas que tem mais de uma dimensão, de maneira que é possível definir o número de eventos e um rnage relacionado a esse evento. Exemplo: número de usuários logados em um site que tenham mais de 18 anos e número de usuários logados no site que tenham menos de 18 anos. Isso cria duas "colunas" em um gráfico, representando um histograma.
* Summary: métricas que tem seus eventos exibidos dentro de um "resumo". Exemplo: número de requests feitos em uma API específica nos últimos 10 minutos. 
