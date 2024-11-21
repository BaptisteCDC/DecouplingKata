# DecouplingKata

## Introduction

Ce kata a pour objectif de vous familiariser avec les concepts de découplage et de programmation asynchrone dans le cadre d'une démarche Green IT. L'idée est de montrer comment un code initialement couplé et synchrone peut être refactorisé pour améliorer à la fois ses performances et son impact environnemental.

## Contexte

Ce kata se déroule dans le cadre d'une billetterie de concert. Les clients doivent pouvoir s'inscrire pour acheter des billets, mais les emails des clients ne seront comptabilisés via le CRM que le mois prochain. Actuellement, le service d'enregistrement (`RegistrationService`) crée des comptes utilisateurs et calcule les coûts en carbone associés. Le service est implémenté de manière synchrone et couplée, ce qui pose des problèmes de performance et d'efficacité énergétique.

## Objectifs

1. **Asynchrone** : Utiliser la programmation asynchrone pour améliorer les performances et réduire l'empreinte carbone.
2. **Découplage** : Séparer les traitements essentiels des traitements qui peuvent être traiter plus tard

## Tests

Les tests actuels montrent que le service d'enregistrement n'est ni performant ni écologique :

- `RegisterShouldTakeLessThan4s` : Vérifie que l'enregistrement prend moins de 4 secondes.
- `RegisterShouldCostLessThan5` : Vérifie que le coût en carbone de l'enregistrement est inférieur à 5 unités.

##Problèmes Actuels

On n'arrive pas avec le code actuel à concillier :
1. Performance : Le service d'enregistrement prend trop de temps à s'exécuter.
2. Impact Environnemental : Le coût en carbone est trop élevé.

## Refactoring
Pour atteindre nos objectifs de performance et de Green IT, un refactoring est nécessaire. Voici quelques pistes :

Asynchrone : Utiliser async et await pour rendre les opérations d'enregistrement non bloquantes.
Conclusion
Découplage : Utiliser une queue pour séparer les traitements principaux des secondaires.

Ce kata vous guidera à travers le processus de refactoring pour améliorer la performance et réduire l'empreinte carbone de votre application. En suivant les principes de découplage et de programmation asynchrone, vous apprendrez à écrire un code plus efficace et plus respectueux de l'environnement.