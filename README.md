<!-- markdownlint-disable MD033 MD041 -->
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>
<!-- markdownlint-enable MD033 MD041 -->

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

# Ejercicio de aplicación del principio *Don't Talk to Strangers*

El siguiente diagrama de clases muestra un auto simplificado:

![diagram](https://kroki.io/plantuml/svg/fP9DIyD048Rl-ok6Ub51y212YvQcrK0Fek11F6woOxfsinjc9vGY_dStkuaq8WKnXsK-dfbtPiZ2ioHkQoCsMY6Kcag3oSQwuJtKM1T8NlYjjeqaMKCXosr5hhLgvOmZO9BMXnHQFg1A8xrV_W5rf90ITd8vlPxUPJ-HZCZjZXAvi_m_86CcNRICnqY_aShjjAtWJHgFGiHIM4aI7mB2vqEJa5s6TTLXuC4fD36WBSChXeBEMOKBSIvRm_jdjDwHFps3MSU8pw7vlQsqnTvvrEQfhPlUoriqQ_kE9JiQy9SD1gLaBmdbjhTJVqXZhdqIZMg5SmPk8OyR1Tcm3PnVp0VXv0P_SbDsPvdrPvbVJNgn1CQQORxlqEzrey7xcWIdCSKXC4f4nHH9syLtX8W5MjNzs5y0)

El auto [`Car`](./src/Library/Car.cs) tiene motor
[`Engine`](./src/Library/Engine.cs) y cuatro ruedas
[`Wheel`](./src/Library/Wheel.cs). El motor tiene bomba de aceite [`OilPump`](./src/Library/OilPump.cs) y cuatro
inyectores de combustible [`FuelInjector`](./src/Library/FuelInjector.cs). Las
ruedas tienen frenos [`Break`](./src/Library/Break.cs). La bomba de aceite, los
inyectores y los frenos tienen sensores [`Sensor`](./src/Library/Sensor.cs).

Los sensores pueden estar fallando o no, según el resultado del método `bool
IsFaulty()` de la clase `Sensor`.

## Parte 1

Analiza el código del método `int CountFaultySensors()` de la clase `Car`
considerando la guía de diseño [Don't Talk to
Strangers](https://github.com/ucudal/PII_Guias/blob/main/Demeter.md).

¿El diseño de este código, cumple o no cumple con la guía? ¿Porqué?

## Parte 2

En caso de que no lo cumpla, ¿qué modificaciones harías al diseño para que
cumpliera?
