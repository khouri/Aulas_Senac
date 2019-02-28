FILE = robocode

all:
	pdflatex -shell-escape -interaction=batchmode $(FILE).tex
	bibtex $(FILE)
	bibtex $(FILE)
	pdflatex -shell-escape -interaction=batchmode  $(FILE).tex 
	pdflatex -shell-escape -interaction=batchmode  $(FILE).tex 
	cp $(FILE).pdf ./PDF/$(FILE).pdf
	mv $(FILE).pdf ./PDF/$(FILE).pdf
	open -a Preview ./PDF/$(FILE).pdf
	make clean
	clear
draft:
	pdflatex -shell-escape -interaction=batchmode  $(FILE).tex
	make clean

clean:
	rm -rf *.aux *.bbl *.toc *.out *.log *.nls *.nlo *.lof *.lot *.blg *.ilg *.gz *.tcp *.brf *.snm *.nav *.bak *.sav
