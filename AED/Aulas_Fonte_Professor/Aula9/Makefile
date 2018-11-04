FILE = Aula09_AED

all:
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex 
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex 
	cp $(FILE).pdf ../../Aulas_PDF_Alunos/Aula9/$(FILE).pdf
	cp ./secoes/Arvores/imprimeEmOrdem.cs ../../Aulas_PDF_Alunos/Aula9/imprimeEmOrdem.cs
	cp ./secoes/Arvores/imprimePosOrdem.cs ../../Aulas_PDF_Alunos/Aula9/imprimePosOrdem.cs
	cp ./secoes/Arvores/imprimePreOrdem.cs ../../Aulas_PDF_Alunos/Aula9/imprimePreOrdem.cs
	mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview ./PDF/$(FILE).pdf
	make clean
	clear
draft:
	pdflatex -shell-escape  -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
