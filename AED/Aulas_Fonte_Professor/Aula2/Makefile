FILE = Aula02_AED

all:
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex 
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex 
	cp $(FILE).pdf ../../Aulas_PDF_Alunos/Aula2/$(FILE).pdf
	cp ./secoes/AnaliseAlgoritmos/encontraminimo.cs ../../Aulas_PDF_Alunos/Aula2/encontraminimo.cs
	cp ./secoes/AnaliseAlgoritmos/sequencialSearch.cs ../../Aulas_PDF_Alunos/Aula2/sequencialSearch.cs
	mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview ./PDF/$(FILE).pdf
	make clean
	clear
draft:
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
