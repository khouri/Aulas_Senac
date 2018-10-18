FILE = Aula08_AED

all:
	pdflatex $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -interaction=batchmode $(FILE).tex 
	pdflatex -interaction=batchmode $(FILE).tex 
	#cp $(FILE).pdf ../../Aulas_PDF_Alunos/Aula01/$(FILE).pdf
	#mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview $(FILE).pdf
	make clean
	clear
draft:
	pdflatex -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
