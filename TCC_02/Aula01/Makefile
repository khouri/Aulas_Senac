FILE = Aula01_TCC_02
name = students

all:
	pdflatex -interaction=batchmode $(FILE).tex
	pdflatex -interaction=batchmode $(FILE).tex 
	mv $(FILE).pdf  ../../Aulas_PDF_Alunos/Aula01/$(FILE).pdf
	make clean
	#open -a Preview ./PDF/$(FILE).pdf
	#echo $(name)
draft:
	pdflatex -interaction=batchmode $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav
