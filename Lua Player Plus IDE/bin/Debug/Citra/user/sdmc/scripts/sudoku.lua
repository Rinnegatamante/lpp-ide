Screen.refresh()
Screen.debugPrint(0,0,"Generating Sudoku...",Color.new(255,255,255),TOP_SCREEN)

function CheckExistenceColumn(n,m,i)
	for j=1,9 do
		if m[i][j] == n then
			return true
		end
	end
	return false
end

function CheckExistenceLine(n,m,i)
	for j=1,9 do
		if m[j][i] == n then
			return true
		end
	end
	return false
end

function CheckExistence(n,m,i,j)
	if CheckExistenceColumn(n,m,j) then
		return true
	else
		if CheckExistenceLine(n,m,i) then
			return true
		else
			return false
		end
	end
end

function GenerateSudoku()
	matrix = {}
	for i=1,9 do
		matrix[i] = {0,0,0,0,0,0,0,0,0}
	end
	h,m,s = System.getTime()
	math.randomseed(h*3600+m*60+s)
	matrix[1][1] = math.random(1,9)
	for i=1,9 do
		for j=1,9 do
			if (not (i == 1 and j == 1)) then
				start_gen = math.random(1,9)
				r = start_gen
				while CheckExistence(r,matrix,i,j) do
					r = r + 1
					if r > 9 then
						r = 1
					end
					if r == start_gen then
						return GenerateSudoku()
					end
				end
				matrix[i][j] = r
			end
		end
	end
	return matrix
end

my_solution = GenerateSudoku()

while true do
	Screen.refresh()
	for i=1,9 do
		for j=1,9 do
			Screen.debugPrint((j-1)*15,(i-1)*15,my_solution[i][j],Color.new(255,255,255),TOP_SCREEN)
		end
	end
	Screen.flip()
	Screen.waitVblankStart()
	if Controls.check(Controls.read,KEY_START) then
		System.exit()
	end
end