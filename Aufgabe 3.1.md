Allgemein
=========

- Instanziieren von vielen gleichen Objekten

Decorator
=========

- Es kann nur eine Pizzagröße für eine Pizza geben, also ist die Größe die Concrete Component und die verschiedenen Beläge die Concrete Decorators.

Composite
=========

- Mögliche Inkonsistenz: Composite kann wieder ein Composite enthalten, das macht für das Beispiel wenig Sinn
- Eine Composite kann beliebig viele Leafs enthalten, es gibt aber nur eine Größe von Pizzen pro Pizza. Also sind die Pizzengrößen nicht Teil des Composite Pattern. Die Component des Composite Pattern ist stattdessen in diesem Beispiel nur der Belag einer Pizza nicht die Pizza selbst.