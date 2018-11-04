FILE = Aula03_TCC_02

all:
	pdflatex $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -interaction=batchmode $(FILE).tex 
	pdflatex -interaction=batchmode $(FILE).tex 
	cp $(FILE).pdf ../../Aulas_PDF_Alunos/Aula01/$(FILE).pdf
	mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview ./PDF/$(FILE).pdf
	make clean
draft:
	pdflatex -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
