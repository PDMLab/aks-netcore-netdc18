#!/usr/bin/env bash
cd ./src/HelloNetCoreOnK8s/HelloNetCoreOnK8s/
docker build -t netdc18.azurecr.io/netdc18-backend .
cd -
cd ./src/HelloNetCoreOnK8s/HelloNetCoreOnK8sFrontend/
docker build -t netdc18.azurecr.io/netdc18-frontend .
cd -