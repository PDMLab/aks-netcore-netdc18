#!/usr/bin/env bash
cd ./src/HelloNetCoreOnK8s/HelloNetCoreOnK8s/
docker build -t pdmlab/netdc18-backend .
cd -
cd ./src/HelloNetCoreOnK8s/HelloNetCoreOnK8sFrontend/
docker build -t pdmlab/netdc18-frontend .
cd -