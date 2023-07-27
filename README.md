# PrometheusDotNetPOC
POC to trainning resources of Prometheus at a .Net Core WebApi

# Overview
O Prometheus é uma ferramenta de monitoramento que obtem, de forma ativa (pulling) métricas de aplicações. O pull é feito em um path '/metrics' da aplicação (isso é pré-requisito), dessa maneira se os dados nesse path estiverem no formato entendível ao Prometheus, o mesmo pega essas informações e as armazena. Este projeto serve para se treinar as funcionalidades básicas do Prometheus do ponto de vista de uma aplicação .Net Core. 

# Metricas
Há 4 tipos de métricas possíveis para se gerar no *'/metrics'* da aplicação para que o Prometheus pegue as informações:
* Counters
* Gauges
* Histogram
* Summary
