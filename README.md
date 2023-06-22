# 06-3DSceneURP-Ondic

### Beschreibung:
3D-Szene für ein gemeinsames Schulprojekt. Fahr simulator wobei man zwischen einem Fahrrad und Auto wählen kann und dann durch die jeweilige Landschaft fährt. Beim Auto fahren muss man bis zum Ende kommen und anderen Autos ausweichen die im Verkehr sind während laute Fahrzeuge durch die Welt donnern. Im Fahrrad level fahrt man durch einen Park mit angenehmen Ambience und sammelt Müll auf und desto mehr Müll man aufsammelt desto mehr Punkte kriegt man.

### Message:
Das man nicht immer den einfachsten Weg nehmen soll, nur für seine eigenen Vorteile und dabei ignoriert wie es andere und die Umwelt betrifft. Sondern mal den "härteren" Weg nehmen soll der im längeren Verlauf besser für einen selbst, mitmenschen und Umwelt ist.

### Ablauf:
Man startet in der "FirstScene" und kann sich dann zwischen den zwei Fahrzeugen entscheiden und dann kommt man zur jeweiligen Scene spielt sie durch und kommt zurück zur "FirstScene" nach completion.

### Sounds:
#### GarageDoor: Der Sound soll für paar Sekunden am Anfang von der CarScene 
und BicycleScene spielen
#### CarEngine: Der Sound ist auf dem Auto drauf und spielt dort gelooped ab
#### CarsHonking: Das wird im Hintergrund durch die ganze Map abspielen und soll 
es nicht so monoton und leise lassen
#### CarTraffic: Das gleiche Prinzip wie beim CarsHonking mit den beiden Sounds
kombiniert soll eine gute Atmosphäre geschafft werden
#### BicycleDriving: Ist auf dem Fahrrad selbst drauf und spiel dort gelooped ab
#### BirdsChirping: Wird im Hintergund abgespielt damit es nicht monoton und leise 
wird
#### WindAmbience: Gleich wie beim BirdsChirping soll Atmosphäre erschaffen und 
zur Map mehr Bezug geben

### Synthaxelemente:
Methodendeklaration: Script-RandomSpawner, Zeile.16
![deklartaion](https://github.com/4ahmns-2223-Sosem/06-3DSceneURP-Ondic/assets/91017666/648d9387-d9cb-42c9-be70-a5e263ab64be)

Methodenaufruf: Script-ScoreSyst, Zeile-33
![aufruf](https://github.com/4ahmns-2223-Sosem/06-3DSceneURP-Ondic/assets/91017666/66282fac-60ab-4250-9fe9-7c1ad6f865a8)

If/else-if: Script-PickUps, Zeile-28
![ifelse](https://github.com/4ahmns-2223-Sosem/06-3DSceneURP-Ondic/assets/91017666/0a8a253f-3298-4a3d-a86b-ce26ca78aa80)

Array: Script-RandomSpawner, Zeile-8
![array](https://github.com/4ahmns-2223-Sosem/06-3DSceneURP-Ondic/assets/91017666/7a2577f0-f2ca-436d-919a-db921eb8b371)


### Enwicklungsplattform: 
+ Windows 10; 
+ Visual studio 2019, 
+ Unit 2020.3.18f1

### Lessons Learned:
Ich hab mehr über Controller steuerungen gelernt, bezüglich des Controllers vom Auto und Fahrrad.

### Limitations:
Fahrrad-Controller funktioniert nicht ganz wie gewünscht und braucht etwas zeit zum beschleunigen. Müll den man aufsammeln muss im Fahrrad Level verschwindet nicht nach dem aufsammeln. Hätte mir mehr gewünscht das es mehr visuell aufgebaut ist aber hab mein Fokus aufs programmieren gelegt. Fahrrad Level hätte eigentlich paar rampen beinhalten soll wo man drüber fahren kann und man hätte mehr freiheit mit dem Fahrrad fahren gehabt war jedoch zu schwer zum umsetzen.
