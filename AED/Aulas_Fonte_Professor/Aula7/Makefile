FILE = Aula07_AED

all:
	pdflatex -interaction=batchmode $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -interaction=batchmode $(FILE).tex 
	pdflatex -interaction=batchmode $(FILE).tex 
	cp $(FILE).pdf ../../Aulas_PDF_Alunos/Aula7/$(FILE).pdf
	mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview ./PDF/$(FILE).pdf
	make clean
	clear
draft:
	pdflatex -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
