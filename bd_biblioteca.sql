-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-12-2021 a las 20:52:22
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bd_biblioteca`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_alumno`
--

CREATE TABLE `tb_alumno` (
  `id_alumno` int(11) NOT NULL,
  `matricula` varchar(50) NOT NULL,
  `nombres` varchar(50) NOT NULL,
  `apellidos` varchar(50) NOT NULL,
  `domicilio` varchar(80) NOT NULL,
  `estatus` int(11) NOT NULL,
  `foto_perfil` varchar(255) NOT NULL,
  `semestre` int(11) NOT NULL,
  `carrera` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_alumno`
--

INSERT INTO `tb_alumno` (`id_alumno`, `matricula`, `nombres`, `apellidos`, `domicilio`, `estatus`, `foto_perfil`, `semestre`, `carrera`) VALUES
(1, '17340346', 'Jaime Alberto', 'Sanchez Martinez', 'Cuba 790', 1, 'C:\\fotos_test\\itn.png', 9, 'ISC'),
(2, '123', 'noan', 'gonzalez', 'prueba', 1, 'C:\\fotos_test\\itn.png', 8, 'ISC');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_devolucion`
--

CREATE TABLE `tb_devolucion` (
  `id_devolucion` int(11) NOT NULL,
  `fecha_max_dev` varchar(80) NOT NULL,
  `fecha_dev` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_estatus`
--

CREATE TABLE `tb_estatus` (
  `id_estatus` int(11) NOT NULL,
  `estatus` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_estatus`
--

INSERT INTO `tb_estatus` (`id_estatus`, `estatus`) VALUES
(1, 'Activo'),
(2, 'Inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_libro`
--

CREATE TABLE `tb_libro` (
  `id_libro` int(11) NOT NULL,
  `codigo_libro` varchar(50) NOT NULL,
  `cantidad_libros` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `autor` varchar(50) NOT NULL,
  `genero` varchar(50) NOT NULL,
  `pais_autor` varchar(50) NOT NULL,
  `no_pag` int(20) NOT NULL,
  `año_edicion` varchar(50) NOT NULL,
  `estatus` int(11) NOT NULL,
  `prestamos` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_libro`
--

INSERT INTO `tb_libro` (`id_libro`, `codigo_libro`, `cantidad_libros`, `nombre`, `autor`, `genero`, `pais_autor`, `no_pag`, `año_edicion`, `estatus`, `prestamos`) VALUES
(1, '1', 17, 'Harry potter', 'prueba', 'prueba', 'USA', 200, '2000', 1, 16),
(2, '2', 16, 'Harry potter 2', 'prueba', 'prueba', 'prueba', 200, '2001', 1, 10);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_prestamo`
--

CREATE TABLE `tb_prestamo` (
  `id_prestamo` int(11) NOT NULL,
  `id_libro` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `id_alumno` int(11) NOT NULL,
  `fecha_salida` varchar(80) NOT NULL,
  `id_devolucion` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tb_usuarios`
--

CREATE TABLE `tb_usuarios` (
  `id_usuario` int(11) NOT NULL,
  `matricula` varchar(50) NOT NULL,
  `usuario` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `estatus` int(11) NOT NULL,
  `privilegios` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `tb_usuarios`
--

INSERT INTO `tb_usuarios` (`id_usuario`, `matricula`, `usuario`, `contraseña`, `correo`, `estatus`, `privilegios`) VALUES
(1, '17340346', 'jaime', '123', 'jaime@gmail.com\r\n', 1, 1),
(2, '123', 'noan', '123', 'noan@gmail.com\r\n', 1, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tb_alumno`
--
ALTER TABLE `tb_alumno`
  ADD PRIMARY KEY (`id_alumno`);

--
-- Indices de la tabla `tb_devolucion`
--
ALTER TABLE `tb_devolucion`
  ADD PRIMARY KEY (`id_devolucion`);

--
-- Indices de la tabla `tb_estatus`
--
ALTER TABLE `tb_estatus`
  ADD PRIMARY KEY (`id_estatus`);

--
-- Indices de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  ADD PRIMARY KEY (`id_libro`);

--
-- Indices de la tabla `tb_prestamo`
--
ALTER TABLE `tb_prestamo`
  ADD PRIMARY KEY (`id_prestamo`),
  ADD KEY `FK_id_libro` (`id_libro`),
  ADD KEY `FK_Id_Usuario` (`id_usuario`),
  ADD KEY `FK_Id_Alumno` (`id_alumno`),
  ADD KEY `FK_Id_devolucion` (`id_devolucion`);

--
-- Indices de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  ADD PRIMARY KEY (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tb_alumno`
--
ALTER TABLE `tb_alumno`
  MODIFY `id_alumno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_devolucion`
--
ALTER TABLE `tb_devolucion`
  MODIFY `id_devolucion` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT de la tabla `tb_estatus`
--
ALTER TABLE `tb_estatus`
  MODIFY `id_estatus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `tb_libro`
--
ALTER TABLE `tb_libro`
  MODIFY `id_libro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `tb_prestamo`
--
ALTER TABLE `tb_prestamo`
  MODIFY `id_prestamo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=115;

--
-- AUTO_INCREMENT de la tabla `tb_usuarios`
--
ALTER TABLE `tb_usuarios`
  MODIFY `id_usuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `tb_prestamo`
--
ALTER TABLE `tb_prestamo`
  ADD CONSTRAINT `tb_prestamo_ibfk_1` FOREIGN KEY (`Id_libro`) REFERENCES `tb_libro` (`Id_libro`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_prestamo_ibfk_2` FOREIGN KEY (`Id_usuario`) REFERENCES `tb_usuarios` (`Id_usuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_prestamo_ibfk_3` FOREIGN KEY (`Id_Alumno`) REFERENCES `tb_alumno` (`Id_Alumno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `tb_prestamo_ibfk_4` FOREIGN KEY (`Id_devolucion`) REFERENCES `tb_devolucion` (`Id_devolucion`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
