
# Lern-Periode 4

## Schach 

In dieser Lernperiode werden Sie sehen, wie ich in acht Wochen versucht habe, ein Schachspiel zu programmieren. Sie können nachverfolgen, wo und wie ich mich in diesen acht Wochen verbessert habe, was mir schwergefallen ist und was leicht gefallen ist.

## Grob-Planung

Ich bin grundsätzlich zufrieden mit meiner Leistung in Informatik. Letztes Semester hatte ich eine 5 im Zeugnis. Allerdings war ich im Modul 162 nicht so gut. Das hat mir jedoch nicht viel ausgemacht, da ich es aufgeholt habe und jetzt im Modul 164 umso härter arbeite.
3. Was wäre ein geeignetes Projekt für diese LP4? Können Sie mit diesem Projekt zeigen, wie Sie sich selbständig in eine Problemstellung einarbeiten können und eine überzeugende Lösung programmieren können?
Ich möchte ein Schachspiel programmieren. Ich weiss nicht, ob es zu schwierig ist, aber ich werde es versuchen.

## 14.2: Explorativer Wegwerf-Prototyp

- [x] Schachbrett 
- [x] Figuren 

✍️Heute habe ich das Schachbrett und die Figuren erstellt. Allerdings überlege ich, beim nächsten Mal von vorne zu beginnen, da ich nicht sicher bin, ob meine aktuelle Methode funktionieren wird. Es hat zwar sehr lange gedauert, das Brett zu gestalten, aber am Ende hat es doch funktioniert, und ich bin sehr zufrieden mit dem Ergebnis, da es wirklich wie ein Schachbrett aussieht.

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 21.2: Explorativer Wegwerf-Prototyp

- [x] pen and paper
- [ ] Neuses Schachbrett
- [ ] Neue Figuren
- [ ] Die ersten Spielfunktienonen vermutlich den Bauern

✍️ Heute habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis einen ersten Code auf github hochzuladen

## 28.2: Kern-Funktionalität

Aus irgendeinem Grund wurde mein letzter GitHub-Eintrag nicht gespeichert. Heute habe ich ein Feld erstellt, was ziemlich aufwendig war, weil ich es aus 64 Buttons gemacht habe und jeden Button einzeln benannt habe. Das hat ziemlich lange gedauert. Meine Idee ist es, Bilder in die Buttons einzufügen und dann die Bilder von Button zu Button zu verschieben, um die Schachfiguren zu bewegen. Ich habe die Bilder jetzt im Ressourcen-Explorer, aber irgendwie konnte ich sie nicht in den Button einfügen. Ich habe versucht, eine MessageBox anzuzeigen, wenn das Bild eingefügt wurde, und die MessageBox ist auch erschienen, aber das Bild war nicht auf dem Button sichtbar, und daran bin ich gescheitert.

## 7.3: Kern-Funktionalität

- [x] Bauern als Bild einfügen
- [x] Der Bauer kann vorwärs gehen
- [ ] Der Bauer kann andere Bauern Schlagen
- [ ] Die restlichen Figuren als Bilder Hinzufügen

Ich habe heute die schwarzen und die weißen Bauern in das Schachbrett eingefügt. Sie können beim ersten Zug zwei Felder gehen und danach nur ein Feld. Allerdings kann er noch nicht schlagen. Das ist ein wenig schwieriger, als ich gedacht habe.

## 14.3: Architektur ausbauen

- [ ] Der Bauer kann andere Bauern Schlagen
- [x] Den Turm einfügen
- [x] Der Turm kann Horizontal und Vertikal fahren
- [x] Die Züge sind abwechselnd.

      
Ich habe versucht, dass die Figuren schlagen können, aber es funktioniert nicht. Ich habe außerdem den Turm eingeführt, und er kann jetzt ziehen, allerdings noch nicht schlagen. Ich weiß noch nicht, warum das so ist. Beim nächsten Mal werde ich es mir genauer anschauen und versuchen, das Schlagen der Figuren zu ermöglichen.
## 21.3: Architektur ausbauen

- [ ] Der Bauer kann eine andere Figur schlagen.
- [x] Ein volles Schachbrett haben.
- [x] Den Läufer einfügen
- [x] Der Läufer kann diagonal fahren.

Ich habe heute die anderen Figuren auf das Schachbrett eingefügt und die Mechanik für den Läufer hinzugefügt, sodass er jetzt diagonal ziehen kann. Das Schlagen funktioniert jedoch immer noch nicht. Ich habe jetzt den Grund dafür herausgefunden: Das Programm denkt, dass ich mit einem weißen Bauern auf einen schwarzen Bauern klicke, um diesen zu bewegen, anstatt ihn zu schlagen.

## 28.3: Auspolieren

- [x] Der König kann ziehen.
- [x] die Königin kann ziehen.
- [x] Ich habe herausgefunden, wie das Programm nicht denkt, dass ich die Figur ziehen möchte, sondern schlagen.
- [x] Der Springer kann ziehen.

Heute war ein richtig guter Tag, weil ich mein Schachspiel fast fertiggestellt habe. Endlich habe ich es geschafft, dass meine Figuren andere Figuren schlagen können. Allerdings fehlt mir noch eine Funktion für den Bauern, und ich möchte das Schachbrett noch schöner gestalten.


## 4.4: Auspolieren & Abschluss

- [ ] Schachbrett schöner machen(Felder mit richtigen Farben und die Zeichen weg machen)
- [ ] Bauer kann sich in andere Figuren verwandeln wenn er an die andere seite kommt. 

Heute war ein schlechter Tag, da ich keines der Arbeitspakete geschafft habe. Zuerst habe ich das ganze Schachfeld in Beige und Braun gemacht, nur um dann zu merken, dass WinForms irgendwie die PNG-Funktionen nicht richtig akzeptiert. Zumindest hat es bei mir nicht funktioniert, also musste ich jedes einzelne Feld wieder ändern.

![Screenshot 2025-04-04 0708](https://github.com/user-attachments/assets/2e8e2319-e614-417a-b59b-f76563e23e38) ![Screenshot 2025-04-04 091709](https://github.com/user-attachments/assets/638b7c78-eb57-48b3-82e5-eec9358fdc8a)


## Reflexion

Das Schachprojekt hat sehr viel Spass gemacht und war ziemlich schwer. Leider bin ich noch nicht fertig geworden, aber ich habe die meisten Funktionen eines Schachspiels hinbekommen. Einige Dinge waren jedoch zu schwierig, und ich wusste nicht, wie ich sie umsetzen sollte, wie zum Beispiel die Verwandlung des Bauern am Ende in eine andere Figur. Ich vermute, ich hatte einfach zu wenig Zeit, da ich zu Beginn Schwierigkeiten hatte, das Schachspiel richtig umzusetzen. Nach einer Weile habe ich jedoch einen guten Flow gefunden und bin schnell vorangekommen. Jetzt bin ich jedoch wieder an einem Punkt, der knifflig ist. Ich möchte das Schachspiel in der nächsten Lernperiode fertigstellen und perfektionieren, da noch einige Dinge zu tun sind. Ich möchte euch jetzt noch mit ein paar Screenshots zeigen, was mein Schachspiel bereits kann. Die Grundlagen stehen schon: Ich kann gewinnen, alle meine Figuren können sich bewegen und sie können sich schlagen.


![Screenshot 2025-04-04 093618](https://github.com/user-attachments/assets/7b3b91d6-880a-4aba-8314-5b8f0f54cb23)


