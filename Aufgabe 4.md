Allgemein
=========

- Häufiges new von eigentlich gleichen Klassen
- Patterns für das Problem häufig zu umfangreich & kompliziert (vllt sinnvolle implementierung? steht ja drinne andere methoden)

Composite vs. Decorator
=======================

- Decorator kann eine speziefische Pizza in einer Zeile definieren ( new Käse(new Soße(new Piccolo)) )
- Composite vllt Vierjahrespizza oder ähnliches als spezieller Fall leicht abbildbar
- Persönlich finde ich Composite für unbefangenen User intuitiver. Es trennt Belag (multiple) und Boden (immer nur einmal) besser voneinander.
