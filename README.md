# Clinic-Doctor-Appointment-System

These project include Store procedure and C# code

![doctor](https://github.com/user-attachments/assets/145eedc8-7b15-4b25-a59a-1ccf5eb7f1a9)
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="430pt" height="433pt" viewBox="0.00 0.00 430.05 433.40">
<g id="graph0" class="graph" transform="scale(1 1) rotate(0) translate(4 429.4)">
<polygon fill="white" stroke="none" points="-4,4 -4,-429.4 426.05,-429.4 426.05,4 -4,4"/>
<!-- Doctor -->
<g id="node1" class="node">
<polygon fill="lightgray" stroke="black" points="0,-324.9 0,-424.9 142.48,-424.9 142.48,-324.9 0,-324.9"/>
<!-- <text text-anchor="middle" x="71.24" y="-408.3" font-family="Times,serif" font-size="14.00">Doctor</text>
<polyline fill="none" stroke="black" points="0,-400.1 142.48,-400.1"/>
<text text-anchor="start" x="8" y="-383.5" font-family="Times,serif" font-size="14.00">+Id: int</text>
<text text-anchor="start" x="8" y="-366.7" font-family="Times,serif" font-size="14.00">+Name: string</text>
<text text-anchor="start" x="8" y="-349.9" font-family="Times,serif" font-size="14.00">+Specialization: string</text>
<text text-anchor="start" x="8" y="-333.1" font-family="Times,serif" font-size="14.00">+Phone: string</text> -->
</g>
<!-- Appointment -->
<!-- <g id="node3" class="node">
<polygon fill="lightgray" stroke="black" points="87.28,-154.3 87.28,-271.1 193.2,-271.1 193.2,-154.3 87.28,-154.3"/>
<text text-anchor="middle" x="140.24" y="-254.5" font-family="Times,serif" font-size="14.00">Appointment</text>
<polyline fill="none" stroke="black" points="87.28,-246.3 193.2,-246.3"/>
<text text-anchor="start" x="95.28" y="-229.7" font-family="Times,serif" font-size="14.00">+Id: int</text>
<text text-anchor="start" x="95.28" y="-212.9" font-family="Times,serif" font-size="14.00">+DoctorId: int</text>
<text text-anchor="start" x="95.28" y="-196.1" font-family="Times,serif" font-size="14.00">+PatientId: int</text>
<text text-anchor="start" x="95.28" y="-179.3" font-family="Times,serif" font-size="14.00">+Date: datetime</text>
<text text-anchor="start" x="95.28" y="-162.5" font-family="Times,serif" font-size="14.00">+Status: string</text>
</g> -->
<!-- Doctor&#45;&gt;Appointment -->
<!-- <g id="edge1" class="edge">
<path fill="none" stroke="black" d="M92.5,-324.53C98.34,-310.99 104.76,-296.07 110.96,-281.69"/>
<polygon fill="black" stroke="black" points="114.08,-283.29 114.82,-272.72 107.65,-280.52 114.08,-283.29"/>
<text text-anchor="middle" x="116.24" y="-293.8" font-family="Times,serif" font-size="14.00">1..*</text>
</g>
<!-- Patient -->
<!-- <g id="node2" class="node">
<polygon fill="lightgray" stroke="black" points="160.15,-324.9 160.15,-424.9 258.33,-424.9 258.33,-324.9 160.15,-324.9"/>
<text text-anchor="middle" x="209.24" y="-408.3" font-family="Times,serif" font-size="14.00">Patient</text>
<polyline fill="none" stroke="black" points="160.15,-400.1 258.33,-400.1"/>
<text text-anchor="start" x="168.15" y="-383.5" font-family="Times,serif" font-size="14.00">+Id: int</text>
<text text-anchor="start" x="168.15" y="-366.7" font-family="Times,serif" font-size="14.00">+Name: string</text>
<text text-anchor="start" x="168.15" y="-349.9" font-family="Times,serif" font-size="14.00">+DOB: date</text>
<text text-anchor="start" x="168.15" y="-333.1" font-family="Times,serif" font-size="14.00">+Phone: string</text>
</g> -->
<!-- Patient&#45;&gt;Appointment -->
<!-- <g id="edge2" class="edge">
<title>Patient-&gt;Appointment</title>
<path fill="none" stroke="black" d="M187.97,-324.53C182.14,-310.99 175.72,-296.07 169.52,-281.69"/>
<polygon fill="black" stroke="black" points="172.83,-280.52 165.66,-272.72 166.4,-283.29 172.83,-280.52"/>
<text text-anchor="middle" x="189.37" y="-293.8" font-family="Times,serif" font-size="14.00">1..*</text>
</g> --> 
<!-- Prescription -->
<!-- <g id="node5" class="node">
<title>Prescription</title>
<polygon fill="lightgray" stroke="black" points="69.4,-0.5 69.4,-100.5 211.08,-100.5 211.08,-0.5 69.4,-0.5"/>
<text text-anchor="middle" x="140.24" y="-83.9" font-family="Times,serif" font-size="14.00">Prescription</text>
<polyline fill="none" stroke="black" points="69.4,-75.7 211.08,-75.7"/>
<text text-anchor="start" x="77.4" y="-59.1" font-family="Times,serif" font-size="14.00">+Id: int</text>
<text text-anchor="start" x="77.4" y="-42.3" font-family="Times,serif" font-size="14.00">+AppointmentId: int</text>
<text text-anchor="start" x="77.4" y="-25.5" font-family="Times,serif" font-size="14.00">+Notes: text</text>
<text text-anchor="start" x="77.4" y="-8.7" font-family="Times,serif" font-size="14.00">+DateIssued: datetime</text>
</g> -->
<!-- Appointment&#45;&gt;Prescription -->
<!-- <g id="edge3" class="edge">
<title>Appointment-&gt;Prescription</title>
<path fill="none" stroke="black" d="M140.24,-153.86C140.24,-140.28 140.24,-125.77 140.24,-112.07"/>
<polygon fill="black" stroke="black" points="143.74,-112.3 140.24,-102.3 136.74,-112.3 143.74,-112.3"/>
<text text-anchor="middle" x="150.74" y="-123.2" font-family="Times,serif" font-size="14.00">1..1</text>
</g> -->
<!-- User -->
<g id="node4" class="node">

</g>
</g>
</svg>
